namespace QLBH
{
    partial class fNewEmployee
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
            cbRoleID = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
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
            SuspendLayout();
            // 
            // cbRoleID
            // 
            cbRoleID.FormattingEnabled = true;
            cbRoleID.Location = new Point(362, 30);
            cbRoleID.Name = "cbRoleID";
            cbRoleID.Size = new Size(178, 28);
            cbRoleID.TabIndex = 41;
            cbRoleID.Validating += cbRoleID_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(243, 29);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 58;
            label7.Text = "Phân quyền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 223);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 57;
            label6.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(469, 216);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(299, 27);
            txtPassword.TabIndex = 48;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(400, 169);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 56;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(469, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 27);
            txtEmail.TabIndex = 47;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(196, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 27);
            dateTimePicker1.TabIndex = 49;
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(638, 281);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 51;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(500, 281);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 50;
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
            ckStatus.Location = new Point(667, 86);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 44;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.CheckAlign = ContentAlignment.MiddleRight;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(559, 86);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(87, 24);
            ckGender.TabIndex = 43;
            ckGender.Text = "Giới tính";
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 223);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 55;
            label4.Text = "Ngày/tháng/năm sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 169);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 54;
            label3.Text = "Điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 126);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 53;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 88);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 52;
            label1.Text = "Tên nhân viên";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(168, 169);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(165, 27);
            txtPhone.TabIndex = 46;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(168, 126);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(600, 27);
            txtAddress.TabIndex = 45;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(372, 27);
            txtName.TabIndex = 42;
            txtName.Validating += txtName_Validating;
            // 
            // fNewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 342);
            Controls.Add(cbRoleID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPassword);
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
            Name = "fNewEmployee";
            Text = "fNewEmployee";
            FormClosing += fNewEmployee_FormClosing;
            Load += fNewEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRoleID;
        private Label label7;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtEmail;
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
    }
}