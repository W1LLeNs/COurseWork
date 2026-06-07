using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace COurseWork
{
    public partial class AdminForm : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        private int selectedBookId = 0; // Змінна для збереження ID вибраної книги

        public AdminForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadBooks();
        }

        // Завантаження жанрів у ComboBox при відкритті форми
        private void LoadCategories()
        {
            try
            {
                dbManager.OpenConnection();
                string query = "SELECT id, category_name FROM categories";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbManager.GetConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "category_name"; // Що бачить адмін
                cmbCategory.ValueMember = "id";              // Що йде в базу
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження категорій: " + ex.Message);
            }
            finally { dbManager.CloseConnection(); }
        }

        // Завантаження списку книг у таблицю
        private void LoadBooks()
        {
            try
            {
                dbManager.OpenConnection();
                string query = @"SELECT b.id, b.title AS 'Назва', b.author AS 'Автор', 
                                        b.price AS 'Ціна', b.stock_quantity AS 'Залишок', 
                                        c.category_name AS 'Жанр', b.categories_id 
                                 FROM books b 
                                 JOIN categories c ON b.categories_id = c.id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbManager.GetConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvAdminBooks.DataSource = dt;
                dgvAdminBooks.Columns["id"].Visible = false; // Ховаємо системні ID
                dgvAdminBooks.Columns["categories_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження книг: " + ex.Message);
            }
            finally { dbManager.CloseConnection(); }
        }

        // Допоміжний метод для очищення текстових полів після дій
        private void ClearFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            selectedBookId = 0;
        }

        // 1. Кнопка РЕДАГУВАТИ (Помаранчева)
        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvAdminBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAdminBooks.SelectedRows[0];
                selectedBookId = Convert.ToInt32(row.Cells["id"].Value);

                // Перекидаємо дані з таблиці в поля ліворуч
                txtTitle.Text = row.Cells["Назва"].Value.ToString();
                txtAuthor.Text = row.Cells["Автор"].Value.ToString();
                txtPrice.Text = row.Cells["Ціна"].Value.ToString();
                txtStock.Text = row.Cells["Залишок"].Value.ToString();

                cmbCategory.SelectedValue = row.Cells["categories_id"].Value;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть книгу в таблиці для редагування!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 2. Кнопка ЗБЕРЕГТИ КНИГУ (Темно-зелена)
        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId == 0)
            {
                MessageBox.Show("Спочатку виберіть книгу через кнопку 'Редагувати'!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dbManager.OpenConnection();
                string query = "UPDATE books SET title=@title, author=@author, price=@price, stock_quantity=@stock, categories_id=@catId WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, dbManager.GetConnection());

                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                cmd.Parameters.AddWithValue("@catId", cmbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@id", selectedBookId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Книгу успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBooks(); // Миттєво оновлюємо таблицю
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оновлення: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { dbManager.CloseConnection(); }
        }

        // 3. Кнопка ДОДАТИ (Синя)
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Заповніть хоча б назву та ціну!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dbManager.OpenConnection();
                string query = "INSERT INTO books (title, author, price, stock_quantity, categories_id) VALUES (@title, @author, @price, @stock, @catId)";
                MySqlCommand cmd = new MySqlCommand(query, dbManager.GetConnection());

                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                cmd.Parameters.AddWithValue("@catId", cmbCategory.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Нову книгу додано до бази!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBooks();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка додавання: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { dbManager.CloseConnection(); }
        }

        // 4. Кнопка ВИДАЛИТИ (Червона)
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvAdminBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть книгу в таблиці для видалення!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Ви впевнені, що хочете безповоротно видалити цю книгу?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int idToDelete = Convert.ToInt32(dgvAdminBooks.SelectedRows[0].Cells["id"].Value);

                    dbManager.OpenConnection();
                    string query = "DELETE FROM books WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, dbManager.GetConnection());
                    cmd.Parameters.AddWithValue("@id", idToDelete);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Книгу видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBooks();
                    ClearFields();
                }
                catch (MySqlException ex)
                {
                    // Код 1451 означає, що запис пов'язаний з іншою таблицею (Foreign Key)
                    if (ex.Number == 1451)
                    {
                        MessageBox.Show("Цю книгу неможливо видалити, оскільки вона вже є в історії замовлень покупців.\n\nЯкщо ви хочете зняти її з продажу, просто відредагуйте її і поставте Залишок = 0.",
                                        "Захист даних бази", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Помилка бази даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbManager.CloseConnection();
                }
            }
        }

        // 5. Велика кнопка ЗБЕРЕГТИ ЗМІНИ (Зверху ліворуч)
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Усі зміни успішно зафіксовано в базі даних!", "Роботу завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Закриваємо вікно
        }
    }
}
