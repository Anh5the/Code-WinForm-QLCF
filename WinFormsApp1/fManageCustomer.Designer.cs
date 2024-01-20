namespace QLBH
{
    partial class fManageCustomer
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
            btNew = new Button();
            btFind = new Button();
            txtName = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewCheckBoxColumn();
            BirthDay = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btNew
            // 
            btNew.Location = new Point(22, 19);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 2;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btFind
            // 
            btFind.Location = new Point(771, 23);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 1;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(606, 20);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên khách hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, CustomerName, Gender, BirthDay, Address, Phone, Email, Status, Edit, Delete });
            dataGridView1.Location = new Point(22, 68);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(839, 271);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.Frozen = true;
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 8;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 116;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerName.DataPropertyName = "Name";
            CustomerName.Frozen = true;
            CustomerName.HeaderText = "Name";
            CustomerName.MinimumWidth = 8;
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 78;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ThreeState = true;
            Gender.Width = 63;
            // 
            // BirthDay
            // 
            BirthDay.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BirthDay.DataPropertyName = "BirthDay";
            BirthDay.HeaderText = "BirthDay";
            BirthDay.MinimumWidth = 6;
            BirthDay.Name = "BirthDay";
            BirthDay.Width = 95;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.Width = 91;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            Phone.Width = 79;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 75;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 55;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(177, 18);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 4;
            label2.Text = "QUẢN LÝ KHÁCH HÀNG";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // fManageCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 360);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btFind);
            Controls.Add(btNew);
            Margin = new Padding(2);
            Name = "fManageCustomer";
            WindowState = FormWindowState.Maximized;
            Activated += fManageCustomer_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNew;
        private Button btFind;
        private TextBox txtName;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewCheckBoxColumn Gender;
        private DataGridViewTextBoxColumn BirthDay;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}