namespace COurseWork
{
    partial class MainForm
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
            dgvBooks = new DataGridView();
            txtSearch = new TextBox();
            cmbCategories = new ComboBox();
            btnAddToCart = new Button();
            btnGoToCart = new Button();
            panel1 = new Panel();
            btnOrders = new Button();
            btnAdminPanel = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = SystemColors.Window;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.Location = new Point(0, 183);
            dgvBooks.Margin = new Padding(4);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1029, 325);
            dgvBooks.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(719, 14);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbCategories
            // 
            cmbCategories.FlatStyle = FlatStyle.Flat;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(256, 15);
            cmbCategories.Margin = new Padding(4);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(242, 29);
            cmbCategories.TabIndex = 2;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            cmbCategories.SelectionChangeCommitted += cmbCategories_SelectionChangeCommitted;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.SeaGreen;
            btnAddToCart.Cursor = Cursors.Hand;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = SystemColors.Window;
            btnAddToCart.Location = new Point(671, 516);
            btnAddToCart.Margin = new Padding(4);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(345, 101);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "ДОДАТИ У КОШИК !";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnGoToCart
            // 
            btnGoToCart.BackColor = Color.DarkSeaGreen;
            btnGoToCart.Cursor = Cursors.Hand;
            btnGoToCart.FlatAppearance.BorderSize = 0;
            btnGoToCart.FlatStyle = FlatStyle.Flat;
            btnGoToCart.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToCart.ForeColor = SystemColors.Window;
            btnGoToCart.Location = new Point(688, 27);
            btnGoToCart.Margin = new Padding(4);
            btnGoToCart.Name = "btnGoToCart";
            btnGoToCart.Size = new Size(286, 69);
            btnGoToCart.TabIndex = 4;
            btnGoToCart.Text = "ПЕРЕЙТИ У КОШИК";
            btnGoToCart.UseVisualStyleBackColor = false;
            btnGoToCart.Click += btnGoToCart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnAdminPanel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnGoToCart);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 122);
            panel1.TabIndex = 5;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.SteelBlue;
            btnOrders.Cursor = Cursors.Hand;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = SystemColors.Window;
            btnOrders.Location = new Point(675, 27);
            btnOrders.Margin = new Padding(4);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(286, 69);
            btnOrders.TabIndex = 7;
            btnOrders.Text = "ЗАМОВЛЕННЯ КЛІЄНТІВ";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.BackColor = Color.FromArgb(192, 0, 0);
            btnAdminPanel.Cursor = Cursors.Hand;
            btnAdminPanel.FlatAppearance.BorderSize = 0;
            btnAdminPanel.FlatStyle = FlatStyle.Flat;
            btnAdminPanel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminPanel.ForeColor = SystemColors.Window;
            btnAdminPanel.Location = new Point(349, 27);
            btnAdminPanel.Margin = new Padding(4);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(286, 69);
            btnAdminPanel.TabIndex = 6;
            btnAdminPanel.Text = "ІНСТРУМЕНТИ АДМІНА";
            btnAdminPanel.UseVisualStyleBackColor = false;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(31, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(276, 45);
            label3.TabIndex = 5;
            label3.Text = "W1LLeNs market";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(70, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 29);
            label1.TabIndex = 0;
            label1.Text = "Каталог Книжок";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(606, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 2;
            label2.Text = "Пошук:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbCategories);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 54);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuText;
            label4.Location = new Point(31, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 24);
            label4.TabIndex = 3;
            label4.Text = "Фільтр за жанром:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnAddToCart);
            Controls.Add(dgvBooks);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головна сторінка";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBooks;
        private TextBox txtSearch;
        private ComboBox cmbCategories;
        private Button btnAddToCart;
        private Button btnGoToCart;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Button btnAdminPanel;
        private Button btnOrders;
    }
}