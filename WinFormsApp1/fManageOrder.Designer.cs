namespace QLBH
{
    partial class fManageOrder
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderTime = new DataGridViewTextBoxColumn();
            ReceiveDate = new DataGridViewTextBoxColumn();
            ReceiveTime = new DataGridViewTextBoxColumn();
            ReceiveAddress = new DataGridViewTextBoxColumn();
            ProgressID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btFind = new Button();
            btNew = new Button();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(464, 23);
            label2.Name = "label2";
            label2.Size = new Size(216, 28);
            label2.TabIndex = 10;
            label2.Text = "QUẢN LÝ ĐƠN HÀNG";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderID, OrderDate, OrderTime, ReceiveDate, ReceiveTime, ReceiveAddress, ProgressID, CustomerID, EmployeeID, Edit, Delete });
            dataGridView1.Location = new Point(27, 118);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1224, 221);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OrderID
            // 
            OrderID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderID.DataPropertyName = "OrderID";
            OrderID.Frozen = true;
            OrderID.HeaderText = "OrderID";
            OrderID.MinimumWidth = 8;
            OrderID.Name = "OrderID";
            OrderID.Width = 91;
            // 
            // OrderDate
            // 
            OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.Frozen = true;
            OrderDate.HeaderText = "OrderDate";
            OrderDate.MinimumWidth = 8;
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 108;
            // 
            // OrderTime
            // 
            OrderTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderTime.DataPropertyName = "OrderTime";
            OrderTime.Frozen = true;
            OrderTime.HeaderText = "OrderTime";
            OrderTime.MinimumWidth = 6;
            OrderTime.Name = "OrderTime";
            OrderTime.Width = 109;
            // 
            // ReceiveDate
            // 
            ReceiveDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReceiveDate.DataPropertyName = "ReceiveDate";
            ReceiveDate.Frozen = true;
            ReceiveDate.HeaderText = "ReceiveDate";
            ReceiveDate.MinimumWidth = 8;
            ReceiveDate.Name = "ReceiveDate";
            ReceiveDate.Width = 121;
            // 
            // ReceiveTime
            // 
            ReceiveTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReceiveTime.DataPropertyName = "ReceiveTime";
            ReceiveTime.Frozen = true;
            ReceiveTime.HeaderText = "ReceiveTime";
            ReceiveTime.MinimumWidth = 8;
            ReceiveTime.Name = "ReceiveTime";
            ReceiveTime.Width = 122;
            // 
            // ReceiveAddress
            // 
            ReceiveAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReceiveAddress.DataPropertyName = "ReceiveAddress";
            ReceiveAddress.Frozen = true;
            ReceiveAddress.HeaderText = "ReceiveAddress";
            ReceiveAddress.MinimumWidth = 8;
            ReceiveAddress.Name = "ReceiveAddress";
            ReceiveAddress.Width = 142;
            // 
            // ProgressID
            // 
            ProgressID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProgressID.DataPropertyName = "ProgressID";
            ProgressID.Frozen = true;
            ProgressID.HeaderText = "ProgressID";
            ProgressID.MinimumWidth = 6;
            ProgressID.Name = "ProgressID";
            ProgressID.Width = 109;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.Frozen = true;
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 116;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.Frozen = true;
            EmployeeID.HeaderText = "EmployeeID";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 119;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.Frozen = true;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 64;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // btFind
            // 
            btFind.Location = new Point(1161, 84);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(27, 82);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 4;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "Tất cả", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbMonth.Location = new Point(657, 83);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(108, 28);
            cbMonth.TabIndex = 1;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(434, 82);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(108, 28);
            cbYear.TabIndex = 0;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(122, 84);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 13;
            label3.Text = "Số lượng hóa đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(581, 85);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 14;
            label1.Text = "Tháng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(370, 85);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 15;
            label4.Text = "Năm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(796, 85);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 16;
            label5.Text = "Ngày đặt hàng";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(931, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // fManageOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 357);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btFind);
            Controls.Add(btNew);
            Name = "fManageOrder";
            Text = "Quản lý Đơn hàng";
            WindowState = FormWindowState.Maximized;
            Activated += fManageOrder_Activated;
            Load += fManageOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Button btFind;
        private Button btNew;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn ReceiveDate;
        private DataGridViewTextBoxColumn ReceiveTime;
        private DataGridViewTextBoxColumn ReceiveAddress;
        private DataGridViewTextBoxColumn ProgressID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}