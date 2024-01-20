namespace QLBH
{
    partial class fEditCustomer
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
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            btClose = new Button();
            btSave = new Button();
            ckStatus = new CheckBox();
            ckGender = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            toolTip1 = new ToolTip(components);
            txtEmail = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(166, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(564, 199);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 8;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(426, 199);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 7;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(624, 42);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 2;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.CheckAlign = ContentAlignment.MiddleRight;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(516, 42);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(87, 24);
            ckGender.TabIndex = 1;
            ckGender.Text = "Giới tính";
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 204);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 19;
            label4.Text = "Ngày/tháng/năm sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 125);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 17;
            label3.Text = "Điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 82);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 15;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 44);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 13;
            label1.Text = "Tên khách hàng";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(125, 125);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(165, 27);
            txtPhone.TabIndex = 4;
            toolTip1.SetToolTip(txtPhone, "Length");
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(125, 82);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(600, 27);
            txtAddress.TabIndex = 3;
            toolTip1.SetToolTip(txtAddress, "Length");
            txtAddress.Validating += txtAddress_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(125, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(372, 27);
            txtName.TabIndex = 0;
            toolTip1.SetToolTip(txtName, "Length");
            txtName.Validating += txtName_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(426, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 27);
            txtEmail.TabIndex = 5;
            toolTip1.SetToolTip(txtEmail, "Length");
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 125);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 22;
            label5.Text = "Email";
            // 
            // fEditCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 269);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(dateTimePicker1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(ckStatus);
            Controls.Add(ckGender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Name = "fEditCustomer";
            Text = "Sửa đổi Khách hàng";
            WindowState = FormWindowState.Maximized;
            FormClosing += fEditCustomer_FormClosing;
            Load += fEditCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btClose;
        private Button btSave;
        private CheckBox ckStatus;
        private CheckBox ckGender;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private ToolTip toolTip1;
        private Label label5;
        private TextBox txtEmail;
    }
}