namespace QLBH
{
    partial class fNewOrder
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btClose = new Button();
            btSave = new Button();
            txtReceiveAddress = new TextBox();
            mOrderTime = new MaskedTextBox();
            mReceiveTime = new MaskedTextBox();
            cbProgresses = new ComboBox();
            cbCustomers = new ComboBox();
            toolTip1 = new ToolTip(components);
            dtReceiveDate = new DateTimePicker();
            dtOrderDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 21);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ giao hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(111, 139);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 2;
            label3.Text = "GIAO HÀNG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 186);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày/tháng/năm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 187);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "Giờ:phút:giây";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(418, 139);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "ĐẶT HÀNG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(466, 188);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 6;
            label7.Text = "Giờ:phút:giây";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(322, 186);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 7;
            label8.Text = "Ngày/tháng/năm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(617, 186);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 8;
            label9.Text = "Tiến trình";
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(881, 221);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 7;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(781, 221);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 6;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // txtReceiveAddress
            // 
            txtReceiveAddress.Location = new Point(418, 44);
            txtReceiveAddress.Name = "txtReceiveAddress";
            txtReceiveAddress.Size = new Size(537, 27);
            txtReceiveAddress.TabIndex = 1;
            txtReceiveAddress.Validating += txtReceiveAddress_Validating;
            // 
            // mOrderTime
            // 
            mOrderTime.Location = new Point(466, 223);
            mOrderTime.Mask = "00:00:00";
            mOrderTime.Name = "mOrderTime";
            mOrderTime.Size = new Size(125, 27);
            mOrderTime.TabIndex = 5;
            mOrderTime.TypeValidationCompleted += mOrderTime_TypeValidationCompleted;
            // 
            // mReceiveTime
            // 
            mReceiveTime.Location = new Point(169, 223);
            mReceiveTime.Mask = "00:00:00";
            mReceiveTime.Name = "mReceiveTime";
            mReceiveTime.Size = new Size(125, 27);
            mReceiveTime.TabIndex = 3;
            mReceiveTime.TypeValidationCompleted += mReceiveTime_TypeValidationCompleted;
            // 
            // cbProgresses
            // 
            cbProgresses.Enabled = false;
            cbProgresses.FormattingEnabled = true;
            cbProgresses.Location = new Point(617, 221);
            cbProgresses.Name = "cbProgresses";
            cbProgresses.Size = new Size(146, 28);
            cbProgresses.TabIndex = 16;
            cbProgresses.Validating += cbProgresses_Validating;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(12, 44);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(373, 28);
            cbCustomers.TabIndex = 0;
            cbCustomers.Validating += cbCustomers_Validating;
            // 
            // dtReceiveDate
            // 
            dtReceiveDate.CustomFormat = "dd/MM/yyyy";
            dtReceiveDate.Format = DateTimePickerFormat.Custom;
            dtReceiveDate.Location = new Point(26, 223);
            dtReceiveDate.Name = "dtReceiveDate";
            dtReceiveDate.Size = new Size(123, 27);
            dtReceiveDate.TabIndex = 2;
            // 
            // dtOrderDate
            // 
            dtOrderDate.CustomFormat = "dd/MM/yyyy";
            dtOrderDate.Format = DateTimePickerFormat.Custom;
            dtOrderDate.Location = new Point(322, 223);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(123, 27);
            dtOrderDate.TabIndex = 4;
            // 
            // fNewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 307);
            ControlBox = false;
            Controls.Add(dtOrderDate);
            Controls.Add(dtReceiveDate);
            Controls.Add(cbCustomers);
            Controls.Add(cbProgresses);
            Controls.Add(mReceiveTime);
            Controls.Add(mOrderTime);
            Controls.Add(txtReceiveAddress);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fNewOrder";
            Text = "Nhập thêm đơn hàng mới";
            WindowState = FormWindowState.Maximized;
            FormClosing += fNewOrder_FormClosing;
            Load += fNewOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btClose;
        private Button btSave;
        private TextBox txtReceiveAddress;
        private MaskedTextBox mOrderTime;
        private MaskedTextBox mReceiveTime;
        private ComboBox cbProgresses;
        private ComboBox cbCustomers;
        private ToolTip toolTip1;
        private DateTimePicker dtReceiveDate;
        private DateTimePicker dtOrderDate;
    }
}