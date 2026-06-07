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

namespace COurseWork // Перевір, чи співпадає з твоїм
{
    public partial class OrdersForm : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();

        public OrdersForm()
        {
            InitializeComponent();
            cmbFilterStatus.SelectedIndex = 0; // За замовчуванням "Усі"
            LoadOrders();
        }

        // Головний метод завантаження (з підтримкою фільтрів)
        private void LoadOrders(string statusFilter = "Усі", string dateFilter = "")
        {
            try
            {
                dbManager.OpenConnection();

                // Базовий запит
                string query = @"SELECT o.id AS 'Номер', 
                                        c.full_name AS 'Клієнт', 
                                        c.phone_number AS 'Телефон', 
                                        o.total_amount AS 'Сума (грн)', 
                                        o.status AS 'Статус',
                                        DATE(o.created_at) AS 'Дата' 
                                 FROM orders o 
                                 JOIN clients c ON o.clients_id = c.id
                                 WHERE 1=1 "; // 1=1 - це трюк, щоб зручно додавати умови AND далі

                // Додаємо фільтр за статусом, якщо він обраний
                if (statusFilter.ToUpper() != "УСІ")
                {
                    query += $" AND o.status = '{statusFilter}'";
                }


                if (!string.IsNullOrEmpty(dateFilter))
                {
                    query += $" AND DATE(o.created_at) = '{dateFilter}'";
                }

                query += " ORDER BY o.id DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbManager.GetConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrders.DataSource = dt;

                dgvOrders.ReadOnly = true;
                dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvOrders.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження замовлень: " + ex.Message);
            }
            finally { dbManager.CloseConnection(); }
        }

        // КНОПКА: Застосувати фільтри
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string selectedStatus = cmbFilterStatus.SelectedItem?.ToString() ?? "УСІ";
            string selectedDate = dtpFilterDate.Value.ToString("yyyy-MM-dd"); // Формат для MySQL

            LoadOrders(selectedStatus, selectedDate);
        }

        // КНОПКА: Скинути фільтри
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbFilterStatus.SelectedIndex = 0;
            dtpFilterDate.Value = DateTime.Now;
            LoadOrders();
        }

        // КНОПКА: Змінити статус (Відповідно до Use Case)
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть замовлення в таблиці!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbUpdateStatus.SelectedItem == null)
            {
                MessageBox.Show("Виберіть новий статус зі списку!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["Номер"].Value);
            string newStatus = cmbUpdateStatus.SelectedItem.ToString();

            try
            {
                dbManager.OpenConnection();
                string query = "UPDATE orders SET status = @status WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, dbManager.GetConnection());
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", orderId);

                cmd.ExecuteNonQuery();
                MessageBox.Show($"Статус замовлення №{orderId} успішно змінено на «{newStatus}»", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Оновлюємо таблицю, щоб побачити зміни, зберігаючи поточні фільтри
                btnApplyFilter_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оновлення статусу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { dbManager.CloseConnection(); }
        }
    }
}
