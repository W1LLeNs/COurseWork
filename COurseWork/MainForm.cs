using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COurseWork
{
    public partial class MainForm : Form
    {
        private DatabaseManager dbManager;
        private int currentUserId;
        private string currentUserName;

        public MainForm(int userId, string userName)
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            currentUserId = userId;
            currentUserName = userName;

            LoadCategories(); // Завантажить жанри у випадаючий список
            LoadBooks();// Завантажить книги в таблицю
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                // Отримуємо дані з виділеного рядка таблиці DataGridView
                int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["ID"].Value);
                string bookTitle = dgvBooks.SelectedRows[0].Cells["Назва книги"].Value.ToString();
                decimal price = Convert.ToDecimal(dgvBooks.SelectedRows[0].Cells["Ціна (грн)"].Value);
                int stock = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["Залишок"].Value);

                if (stock <= 0)
                {
                    MessageBox.Show("На жаль, цієї книги немає в наявності!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Додаємо в наш статичний кошик
                ShoppingCart.AddProduct(bookId, bookTitle, price);
                MessageBox.Show($"Книгу «{bookTitle}» додано до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть книгу з таблиці!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGoToCart_Click(object sender, EventArgs e)
        {
            // Відкриваємо вікно кошика та передаємо туди ID поточного користувача для оформлення
            CartForm cartForm = new CartForm(currentUserId);
            cartForm.ShowDialog();

            // Після закриття вікна кошика оновлюємо таблицю книг, бо кількість на складі могла змінитися
            LoadBooks();
        }
        private void LoadBooks()
        {
            try
            {
                dbManager.OpenConnection();

                string query = @"SELECT b.id AS 'ID', b.title AS 'Назва книги', b.author AS 'Автор', 
                                b.price AS 'Ціна (грн)', b.stock_quantity AS 'Залишок', 
                                c.category_name AS 'Жанр'
                         FROM books b
                         JOIN categories c ON b.categories_id = c.id
                         WHERE 1=1";

                // Додаємо умови фільтрації, якщо елементи пошуку створені
                if (txtSearch != null && !string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    query += " AND (b.title LIKE @search OR b.author LIKE @search)";
                }

                if (cmbCategories != null && cmbCategories.SelectedValue != null && (int)cmbCategories.SelectedValue > 0)
                {
                    query += " AND b.categories_id = @categoryId";
                }

                MySqlCommand command = new MySqlCommand(query, dbManager.GetConnection());

                if (txtSearch != null && !string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    command.Parameters.AddWithValue("@search", $"%{txtSearch.Text.Trim()}%");
                }
                if (cmbCategories != null && cmbCategories.SelectedValue != null && (int)cmbCategories.SelectedValue > 0)
                {
                    command.Parameters.AddWithValue("@categoryId", cmbCategories.SelectedValue);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження книг: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void LoadCategories()
        {
            try
            {
                dbManager.OpenConnection();
                string query = "SELECT id, category_name FROM categories";
                MySqlCommand command = new MySqlCommand(query, dbManager.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow row = dt.NewRow();
                row["id"] = 0;
                row["category_name"] = "Усі жанри";
                dt.Rows.InsertAt(row, 0);

                cmbCategories.DataSource = dt;
                cmbCategories.DisplayMember = "category_name";
                cmbCategories.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження категорій: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void cmbCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}
