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
    public partial class RegisterForm : Form
    {
        private DatabaseManager dbManager;
        public RegisterForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }




        private void btnRegisterUser_Click(object sender, EventArgs e)

        {

            // 1. Валідація: перевіряємо, чи користувач не залишив поля порожніми

            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||

                string.IsNullOrWhiteSpace(txtEmail.Text) ||

                string.IsNullOrWhiteSpace(txtPassword.Text))

            {

                MessageBox.Show("Будь ласка, заповніть усі обов'язкові поля (ПІБ, Email, Пароль)!", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            try

            {
                dbManager.OpenConnection();

                // 2. Перевірка на унікальність: чи немає вже такого email в базі

                string checkEmailQuery = "SELECT COUNT(*) FROM clients WHERE email = @email";

                MySqlCommand checkCmd = new MySqlCommand(checkEmailQuery, dbManager.GetConnection());

                checkCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());



                long emailCount = Convert.ToInt64(checkCmd.ExecuteScalar());



                if (emailCount > 0)

                {

                    MessageBox.Show("Користувач з таким Email вже існує в системі!", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }



                // 3. Запис у БД: якщо все ок — створюємо новий акаунт

                string insertQuery = @"INSERT INTO clients (full_name, email, phone_number, password) 

                                       VALUES (@fullName, @email, @phone, @password)";



                MySqlCommand insertCmd = new MySqlCommand(insertQuery, dbManager.GetConnection());

                insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());

                insertCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                insertCmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim()); // Сюди запишеться телефон (можна залишити порожнім)

                insertCmd.Parameters.AddWithValue("@password", txtPassword.Text); // Пароль пишемо як є



                insertCmd.ExecuteNonQuery();



                // 4. Успішне завершення

                MessageBox.Show("Акаунт успішно створено! Тепер ви можете увійти в систему, використовуючи свій Email та Пароль.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);



                this.Close(); // Автоматично закриваємо форму реєстрації та повертаємося до логіну

            }

            catch (Exception ex)

            {

                MessageBox.Show($"Помилка при збереженні в базу даних: {ex.Message}", "Критична помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally

            {

                dbManager.CloseConnection();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
