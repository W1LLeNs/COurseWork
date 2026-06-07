namespace COurseWork
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnSaveAll = new Button();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnSaveBook = new Button();
            btnAddBook = new Button();
            btnEditBook = new Button();
            btnDeleteBook = new Button();
            cmbCategory = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtAuthor = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            dgvAdminBooks = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnSaveAll);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 129);
            panel1.TabIndex = 0;
            // 
            // btnSaveAll
            // 
            btnSaveAll.BackColor = Color.FromArgb(0, 192, 0);
            btnSaveAll.Cursor = Cursors.Hand;
            btnSaveAll.FlatAppearance.BorderSize = 0;
            btnSaveAll.FlatStyle = FlatStyle.Flat;
            btnSaveAll.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAll.ForeColor = SystemColors.Window;
            btnSaveAll.Location = new Point(15, 17);
            btnSaveAll.Margin = new Padding(4);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(347, 88);
            btnSaveAll.TabIndex = 15;
            btnSaveAll.Text = "ЗБЕРЕГТИ ЗМІНИ";
            btnSaveAll.UseVisualStyleBackColor = false;
            btnSaveAll.Click += btnSaveAll_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(559, 16);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(354, 60);
            label3.TabIndex = 7;
            label3.Text = "W1LLeNs market";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(570, 76);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(338, 29);
            label1.TabIndex = 6;
            label1.Text = "Інструмент Адміністратора";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnSaveBook);
            panel2.Controls.Add(btnAddBook);
            panel2.Controls.Add(btnEditBook);
            panel2.Controls.Add(btnDeleteBook);
            panel2.Controls.Add(cmbCategory);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtStock);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTitle);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 129);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 501);
            panel2.TabIndex = 1;
            // 
            // btnSaveBook
            // 
            btnSaveBook.BackColor = Color.Green;
            btnSaveBook.Cursor = Cursors.Hand;
            btnSaveBook.FlatAppearance.BorderSize = 0;
            btnSaveBook.FlatStyle = FlatStyle.Flat;
            btnSaveBook.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveBook.ForeColor = SystemColors.Window;
            btnSaveBook.Location = new Point(204, 309);
            btnSaveBook.Margin = new Padding(4);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(178, 87);
            btnSaveBook.TabIndex = 17;
            btnSaveBook.Text = "ЗБЕРЕГТИ КНИГУ";
            btnSaveBook.UseVisualStyleBackColor = false;
            btnSaveBook.Click += btnSaveBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(0, 0, 192);
            btnAddBook.Cursor = Cursors.Hand;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBook.ForeColor = SystemColors.Window;
            btnAddBook.Location = new Point(15, 309);
            btnAddBook.Margin = new Padding(4);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(183, 87);
            btnAddBook.TabIndex = 16;
            btnAddBook.Text = "ДОДАТИ";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.BackColor = Color.FromArgb(255, 128, 0);
            btnEditBook.Cursor = Cursors.Hand;
            btnEditBook.FlatAppearance.BorderSize = 0;
            btnEditBook.FlatStyle = FlatStyle.Flat;
            btnEditBook.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditBook.ForeColor = SystemColors.Window;
            btnEditBook.Location = new Point(204, 403);
            btnEditBook.Margin = new Padding(4);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(178, 81);
            btnEditBook.TabIndex = 15;
            btnEditBook.Text = "РЕДАГУВАТИ";
            btnEditBook.UseVisualStyleBackColor = false;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteBook.Cursor = Cursors.Hand;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteBook.ForeColor = SystemColors.Window;
            btnDeleteBook.Location = new Point(15, 403);
            btnDeleteBook.Margin = new Padding(4);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(183, 81);
            btnDeleteBook.TabIndex = 14;
            btnDeleteBook.Text = "ВИДАЛИТИ";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(15, 271);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(367, 29);
            cmbCategory.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 246);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(249, 21);
            label7.TabIndex = 9;
            label7.Text = "Категорія (жанр, підвид літ-ри):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 188);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 21);
            label6.TabIndex = 7;
            label6.Text = "Залишок (к-сть в шт.):";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(14, 213);
            txtStock.Margin = new Padding(4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(368, 29);
            txtStock.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 130);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 5;
            label5.Text = "Ціна (грн):";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(14, 155);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(368, 29);
            txtPrice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 3;
            label4.Text = "Автор:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(14, 97);
            txtAuthor.Margin = new Padding(4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(368, 29);
            txtAuthor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 1;
            label2.Text = "Назва видання:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(15, 39);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(367, 29);
            txtTitle.TabIndex = 0;
            // 
            // dgvAdminBooks
            // 
            dgvAdminBooks.AllowUserToAddRows = false;
            dgvAdminBooks.AllowUserToDeleteRows = false;
            dgvAdminBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminBooks.BackgroundColor = SystemColors.Window;
            dgvAdminBooks.BorderStyle = BorderStyle.None;
            dgvAdminBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAdminBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvAdminBooks.DefaultCellStyle = dataGridViewCellStyle1;
            dgvAdminBooks.Location = new Point(408, 129);
            dgvAdminBooks.Margin = new Padding(5, 6, 5, 6);
            dgvAdminBooks.Name = "dgvAdminBooks";
            dgvAdminBooks.ReadOnly = true;
            dgvAdminBooks.RowHeadersVisible = false;
            dgvAdminBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdminBooks.Size = new Size(621, 501);
            dgvAdminBooks.TabIndex = 2;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1029, 630);
            Controls.Add(dgvAdminBooks);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Інструмент Адміністратора: Керування книгами";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtTitle;
        private DataGridView dgvAdminBooks;
        private ComboBox cmbCategory;
        private Button btnDeleteBook;
        private Button btnSaveAll;
        private Button btnAddBook;
        private Button btnEditBook;
        private Button btnSaveBook;
    }
}