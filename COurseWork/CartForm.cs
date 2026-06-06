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
    public partial class CartForm : Form
    {
        private DatabaseManager dbManager;
        private int userId;

        public CartForm(int currentUserId)
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            userId = currentUserId;

            DisplayCart();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            DisplayCart();
        }

        // Метод виведення списку товарів у таблицю
        public void DisplayCart()
        {
            // Скидаємо джерело даних, щоб таблиця примусово оновилася
            dgvCart.DataSource = null;

            if (ShoppingCart.Items != null && ShoppingCart.Items.Count > 0)
            {
                // Прив'язуємо список наново
                dgvCart.DataSource = ShoppingCart.Items;

                // Налаштовуємо зрозумілі заголовки колонок для викладача
                if (dgvCart.Columns["BookId"] != null) dgvCart.Columns["BookId"].Visible = false; // Хваємо ID
                if (dgvCart.Columns["Title"] != null) dgvCart.Columns["Title"].HeaderText = "Назва книги";
                if (dgvCart.Columns["Price"] != null) dgvCart.Columns["Price"].HeaderText = "Ціна (грн)";
                if (dgvCart.Columns["Quantity"] != null) dgvCart.Columns["Quantity"].HeaderText = "Кількість";
            }

            // Оновлюємо текст із загальною сумою
            lblTotal.Text = $"Разом до сплати: {ShoppingCart.GetTotalAmount()} грн.";
        }

        // Кнопка оформлення замовлення (Транзакція MySQL)
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (ShoppingCart.Items.Count == 0)
            {
                MessageBox.Show("Ваш кошик порожній!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection connection = dbManager.GetConnection();
            MySqlTransaction transaction = null;

            try
            {
                dbManager.OpenConnection();
                // Починаємо транзакцію
                transaction = connection.BeginTransaction();

                // 1. Створюємо запис у таблиці orders
                string insertOrderQuery = "INSERT INTO orders (total_amount, status, clients_id) VALUES (@total, 'NEW', @clientId);";
                MySqlCommand orderCommand = new MySqlCommand(insertOrderQuery, connection, transaction);
                orderCommand.Parameters.AddWithValue("@total", ShoppingCart.GetTotalAmount());
                orderCommand.Parameters.AddWithValue("@clientId", userId);
                orderCommand.ExecuteNonQuery();

                // Отримуємо ID щойно створеного замовлення
                long orderId = orderCommand.LastInsertedId;

                // Проходимо по кожному товару в кошику
                foreach (var item in ShoppingCart.Items)
                {
                    // Перевіряємо, чи є фізично книга на складі в потрібній кількості
                    string checkStockQuery = "SELECT stock_quantity FROM books WHERE id = @bookId";
                    MySqlCommand checkCommand = new MySqlCommand(checkStockQuery, connection, transaction);
                    checkCommand.Parameters.AddWithValue("@bookId", item.BookId);
                    int currentStock = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (currentStock < item.Quantity)
                    {
                        throw new Exception($"Недостатньо товару на складі для книги з ID {item.BookId}!");
                    }

                    // Додаємо запис у деталі замовлення (order_items)
                    string insertItemQuery = @"INSERT INTO order_items (quantity, price_at_purchase, orders_id, books_id) 
                                               VALUES (@qty, @price, @orderId, @bookId);";
                    MySqlCommand itemCommand = new MySqlCommand(insertItemQuery, connection, transaction);
                    itemCommand.Parameters.AddWithValue("@qty", item.Quantity);
                    itemCommand.Parameters.AddWithValue("@price", item.Price);
                    itemCommand.Parameters.AddWithValue("@orderId", orderId);
                    itemCommand.Parameters.AddWithValue("@bookId", item.BookId);
                    itemCommand.ExecuteNonQuery();

                    // Зменшуємо залишок книги на складі (списання)
                    string updateStockQuery = "UPDATE books SET stock_quantity = stock_quantity - @qty WHERE id = @bookId";
                    MySqlCommand updateCommand = new MySqlCommand(updateStockQuery, connection, transaction);
                    updateCommand.Parameters.AddWithValue("@qty", item.Quantity);
                    updateCommand.Parameters.AddWithValue("@bookId", item.BookId);
                    updateCommand.ExecuteNonQuery();
                }

                // Якщо все пройшло без помилок - фіксую транзакцію в БД
                transaction.Commit();

                MessageBox.Show(
                    "Ваше замовлення успішно прийняте!\n\nУ найближчий час наш менеджер зв'яжеться з вами за номером телефону  для підтвердження і уточнення деталей!",
                    "Замовлення оформлено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShoppingCart.Clear(); // Очищаємо кошик
                this.Close();         // Закриваємо форму
            }
            catch (Exception ex)
            {
                // Якщо виникла помилка — скасовую усі зміни
                if (transaction != null) transaction.Rollback();
                MessageBox.Show($"Помилка оформлення замовлення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }
    }
}
