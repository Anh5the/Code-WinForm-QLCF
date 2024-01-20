namespace QLBH
{
    partial class fEditOrder
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
            cbProgresses = new ComboBox();
            mReceiveTime = new MaskedTextBox();
            txtReceiveAddress = new TextBox();
            btClose = new Button();
            btSave = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbCustomers = new ComboBox();
            toolTip1 = new ToolTip(components);
            mOrderTime = new MaskedTextBox();
            dtOrderDate = new DateTimePicker();
            dtReceiveDate = new DateTimePicker();
            SuspendLayout();
            // 
            // cbProgresses
            // 
            cbProgresses.FormattingEnabled = true;
            cbProgresses.Location = new Point(617, 239);
            cbProgresses.Name = "cbProgresses";
            cbProgresses.Size = new Size(146, 28);
            cbProgresses.TabIndex = 34;
            cbProgresses.Validating += cbProgresses_Validating;
            // 
            // mReceiveTime
            // 
            mReceiveTime.Enabled = false;
            mReceiveTime.Location = new Point(169, 241);
            mReceiveTime.Mask = "00:00:00";
            mReceiveTime.Name = "mReceiveTime";
            mReceiveTime.Size = new Size(125, 27);
            mReceiveTime.TabIndex = 3;
            // 
            // txtReceiveAddress
            // 
            txtReceiveAddress.Location = new Point(418, 62);
            txtReceiveAddress.Name = "txtReceiveAddress";
            txtReceiveAddress.Size = new Size(537, 27);
            txtReceiveAddress.TabIndex = 1;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(881, 239);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 7;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(781, 239);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 6;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(617, 204);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 33;
            label9.Text = "Tiến trình";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(322, 204);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 32;
            label8.Text = "Ngày/tháng/năm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(466, 206);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 29;
            label7.Text = "Giờ:phút:giây";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(418, 157);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 28;
            label6.Text = "ĐẶT HÀNG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 205);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 26;
            label5.Text = "Giờ:phút:giây";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 204);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 24;
            label4.Text = "Ngày/tháng/năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(111, 157);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 22;
            label3.Text = "GIAO HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 39);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 20;
            label2.Text = "Địa chỉ giao hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 18;
            label1.Text = "Khách hàng";
            // 
            // cbCustomers
            // 
            cbCustomers.Enabled = false;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(12, 62);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(373, 28);
            cbCustomers.TabIndex = 0;
            // 
            // mOrderTime
            // 
            mOrderTime.Enabled = false;
            mOrderTime.Location = new Point(466, 241);
            mOrderTime.Mask = "00:00:00";
            mOrderTime.Name = "mOrderTime";
            mOrderTime.Size = new Size(125, 27);
            mOrderTime.TabIndex = 5;
            // 
            // dtOrderDate
            // 
            dtOrderDate.CustomFormat = "dd/MM/yyyy";
            dtOrderDate.Format = DateTimePickerFormat.Custom;
            dtOrderDate.Location = new Point(322, 240);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(123, 27);
            dtOrderDate.TabIndex = 4;
            // 
            // dtReceiveDate
            // 
            dtReceiveDate.CustomFormat = "dd/MM/yyyy";
            dtReceiveDate.Format = DateTimePickerFormat.Custom;
            dtReceiveDate.Location = new Point(26, 240);
            dtReceiveDate.Name = "dtReceiveDate";
            dtReceiveDate.Size = new Size(123, 27);
            dtReceiveDate.TabIndex = 2;
            // 
            // fEditOrder
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
            Name = "fEditOrder";
            Text = "Sửa đổi Đơn hàng";
            WindowState = FormWindowState.Maximized;
            FormClosing += fEditOrder_FormClosing;
            Load += fEditOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbProgresses;
        private MaskedTextBox mReceiveTime;
        private TextBox txtReceiveAddress;
        private Button btClose;
        private Button btSave;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbCustomers;
        private ToolTip toolTip1;
        private MaskedTextBox mOrderTime;
        private DateTimePicker dtOrderDate;
        private DateTimePicker dtReceiveDate;
    }
}