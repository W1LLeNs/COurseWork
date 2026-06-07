namespace COurseWork
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegisterUser = new Button();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisterUser
            // 
            btnRegisterUser.BackColor = Color.SeaGreen;
            btnRegisterUser.CausesValidation = false;
            btnRegisterUser.Cursor = Cursors.Hand;
            btnRegisterUser.FlatAppearance.BorderSize = 0;
            btnRegisterUser.FlatStyle = FlatStyle.Flat;
            btnRegisterUser.ForeColor = SystemColors.Window;
            btnRegisterUser.Location = new Point(73, 301);
            btnRegisterUser.Margin = new Padding(4);
            btnRegisterUser.Name = "btnRegisterUser";
            btnRegisterUser.Size = new Size(283, 92);
            btnRegisterUser.TabIndex = 0;
            btnRegisterUser.Text = "Зареєструватися!";
            btnRegisterUser.UseVisualStyleBackColor = false;
            btnRegisterUser.Click += btnRegisterUser_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(218, 114);
            txtFullName.Margin = new Padding(4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(175, 29);
            txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 151);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 29);
            txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(218, 188);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(175, 29);
            txtPhone.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(218, 225);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 29);
            txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 6;
            label2.Text = "Повне ім'я:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 7;
            label3.Text = "Електронна пошта:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 191);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 8;
            label4.Text = "Номер телефону:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 228);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 9;
            label5.Text = "Пароль:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnRegisterUser);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(213, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 447);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(153, 41);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 30);
            label6.TabIndex = 4;
            label6.Text = "Реєстрація";
            label6.Click += label6_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(857, 587);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстрація";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterUser;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label6;
    }
}