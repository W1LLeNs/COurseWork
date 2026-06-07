namespace COurseWork
{
    partial class OrdersForm
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
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            cmbFilterStatus = new ComboBox();
            dtpFilterDate = new DateTimePicker();
            button1btnApplyFilter = new Button();
            btnClearFilter = new Button();
            label4 = new Label();
            cmbUpdateStatus = new ComboBox();
            btnUpdateStatus = new Button();
            label5 = new Label();
            dgvOrders = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(17, 4);
            label3.Margin = new Padding(6, 0, 6, 0);
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
            label1.Location = new Point(64, 88);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 29);
            label1.TabIndex = 6;
            label1.Text = "Замовлення Клієнтів";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 137);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 2;
            label2.Text = "Фільтр за статусом:";
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Items.AddRange(new object[] { "УСІ", "NEW", "ОПЛАЧЕНО", "ВІДПРАВЛЕНО" });
            cmbFilterStatus.Location = new Point(13, 172);
            cmbFilterStatus.Margin = new Padding(4);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(317, 29);
            cmbFilterStatus.TabIndex = 3;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Location = new Point(13, 230);
            dtpFilterDate.Margin = new Padding(4);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(317, 29);
            dtpFilterDate.TabIndex = 4;
            // 
            // button1btnApplyFilter
            // 
            button1btnApplyFilter.BackColor = Color.SteelBlue;
            button1btnApplyFilter.FlatAppearance.BorderSize = 0;
            button1btnApplyFilter.FlatStyle = FlatStyle.Flat;
            button1btnApplyFilter.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1btnApplyFilter.ForeColor = SystemColors.Window;
            button1btnApplyFilter.Location = new Point(13, 267);
            button1btnApplyFilter.Margin = new Padding(4);
            button1btnApplyFilter.Name = "button1btnApplyFilter";
            button1btnApplyFilter.Size = new Size(318, 73);
            button1btnApplyFilter.TabIndex = 5;
            button1btnApplyFilter.Text = "ЗАСТОСУВАТИ ФІЛЬТР";
            button1btnApplyFilter.UseVisualStyleBackColor = false;
            button1btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.OrangeRed;
            btnClearFilter.FlatAppearance.BorderSize = 0;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFilter.ForeColor = SystemColors.Window;
            btnClearFilter.Location = new Point(13, 348);
            btnClearFilter.Margin = new Padding(4);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(318, 44);
            btnClearFilter.TabIndex = 6;
            btnClearFilter.Text = "СКИНУТИ";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 434);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(317, 21);
            label4.TabIndex = 7;
            label4.Text = "Змінити статус обраного замовлення на:\r\n";
            // 
            // cmbUpdateStatus
            // 
            cmbUpdateStatus.FormattingEnabled = true;
            cmbUpdateStatus.Items.AddRange(new object[] { "NEW", "ОПЛАЧЕНО", "ВІДПРАВЛЕНО" });
            cmbUpdateStatus.Location = new Point(12, 468);
            cmbUpdateStatus.Margin = new Padding(4);
            cmbUpdateStatus.Name = "cmbUpdateStatus";
            cmbUpdateStatus.Size = new Size(318, 29);
            cmbUpdateStatus.TabIndex = 8;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.SeaGreen;
            btnUpdateStatus.FlatAppearance.BorderSize = 0;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStatus.ForeColor = SystemColors.Window;
            btnUpdateStatus.Location = new Point(13, 505);
            btnUpdateStatus.Margin = new Padding(4);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(318, 73);
            btnUpdateStatus.TabIndex = 9;
            btnUpdateStatus.Text = "ЗБЕРЕГТИ СТАТУС";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 205);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 10;
            label5.Text = "Фільтр за часом:";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = SystemColors.Window;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.Location = new Point(338, 147);
            dgvOrders.Margin = new Padding(4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(687, 470);
            dgvOrders.TabIndex = 11;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(dgvOrders);
            Controls.Add(label5);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbUpdateStatus);
            Controls.Add(label4);
            Controls.Add(btnClearFilter);
            Controls.Add(button1btnApplyFilter);
            Controls.Add(dtpFilterDate);
            Controls.Add(cmbFilterStatus);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клієнтські замовлення";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbFilterStatus;
        private DateTimePicker dtpFilterDate;
        private Button button1btnApplyFilter;
        private Button btnClearFilter;
        private Label label4;
        private ComboBox cmbUpdateStatus;
        private Button btnUpdateStatus;
        private Label label5;
        private DataGridView dgvOrders;
    }
}