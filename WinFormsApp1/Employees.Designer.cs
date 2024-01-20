namespace QLBH
{
    partial class Employees
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
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewCheckBoxColumn();
            BirthDay = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            RoleID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            txtName = new TextBox();
            btFind = new Button();
            btNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(222, 19);
            label2.Name = "label2";
            label2.Size = new Size(217, 28);
            label2.TabIndex = 10;
            label2.Text = "QUẢN LÝ NHÂN VIÊN";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, Gender, BirthDay, Address, Phone, Email, Status, Password, RoleID, Edit, Delete });
            dataGridView1.Location = new Point(39, 70);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1024, 271);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.Frozen = true;
            EmployeeID.HeaderText = "EmployeeID";
            EmployeeID.MinimumWidth = 8;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 119;
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeName.DataPropertyName = "Name";
            EmployeeName.Frozen = true;
            EmployeeName.HeaderText = "Name";
            EmployeeName.MinimumWidth = 8;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.Width = 78;
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
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 8;
            Password.Name = "Password";
            Password.Width = 99;
            // 
            // RoleID
            // 
            RoleID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RoleID.DataPropertyName = "RoleID";
            RoleID.HeaderText = "RoleID";
            RoleID.MinimumWidth = 8;
            RoleID.Name = "RoleID";
            RoleID.Width = 83;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(568, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 9;
            label1.Text = "Tên nhân viên";
            // 
            // txtName
            // 
            txtName.Location = new Point(714, 26);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 5;
     
            // 
            // btFind
            // 
            btFind.Location = new Point(973, 26);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 6;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(39, 21);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 7;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 360);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btFind);
            Controls.Add(btNew);
            Margin = new Padding(2);
            Name = "Employees";
            Text = "Employees";
            Activated += Employees_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtName;
        private Button btFind;
        private Button btNew;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewCheckBoxColumn Gender;
        private DataGridViewTextBoxColumn BirthDay;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn RoleID;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}