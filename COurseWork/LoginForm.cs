using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace COurseWork
{
    public partial class LoginForm : Form
    {
        private DatabaseManager dbManager;

        public LoginForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dbManager.OpenConnection();

                // ЗМІНА 1: Додали role у список SELECT (видалили password, бо він тут не потрібен)
                string query = "SELECT id, full_name, role FROM clients WHERE email = @email AND password = @password";

                MySqlCommand command = new MySqlCommand(query, dbManager.GetConnection());
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32("id");
                    string userName = reader.GetString("full_name");
                    string userRole = reader.GetString("role"); // ЗМІНА 2: Читаємо роль з БД

                    // ЗМІНА 3: Записуємо дані у статичний клас сесії
                    CurrentUser.Id = userId;
                    CurrentUser.Role = userRole;

                    MessageBox.Show($"Успішний вхід! Вітаємо, {userName}.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Приховуємо форму логіну та відкриваємо головну форму каталогу книг
                    this.Hide();
                    MainForm mainForm = new MainForm(userId, userName); // Залишили без змін!
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невірний Email або Пароль!", "Помилка доступу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка підключення до бази даних: {ex.Message}", "Критична помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр форми реєстрації
            RegisterForm regForm = new RegisterForm();

            // Показуємо її як модальне вікно
            regForm.ShowDialog();
        }
    }
}