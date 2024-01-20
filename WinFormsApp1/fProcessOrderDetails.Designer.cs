namespace QLBH
{
    partial class fProcessOrderDetails
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            cbProgresses = new ComboBox();
            cbOrders = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            dtOrderDate = new DateTimePicker();
            label12 = new Label();
            mOrderTime = new MaskedTextBox();
            label13 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            dtReceiveDate = new DateTimePicker();
            label6 = new Label();
            mReceiveTime = new MaskedTextBox();
            label7 = new Label();
            panel4 = new Panel();
            btCancel = new Button();
            label8 = new Label();
            btAddOrderDetail = new Button();
            mPrice = new MaskedTextBox();
            mQuantity = new MaskedTextBox();
            cbProducts = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            btClose = new Button();
            btSave = new Button();
            cbCustomers = new ComboBox();
            txtReceiveAddress = new TextBox();
            dataGridView1 = new DataGridView();
            Delete = new DataGridViewButtonColumn();
            OrderDetailID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            OrderID = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 21);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ giao hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 25);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Tiến trình";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbProgresses);
            panel1.Controls.Add(cbOrders);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(30, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 119);
            panel1.TabIndex = 3;
            // 
            // cbProgresses
            // 
            cbProgresses.Enabled = false;
            cbProgresses.FormattingEnabled = true;
            cbProgresses.Location = new Point(14, 60);
            cbProgresses.Name = "cbProgresses";
            cbProgresses.Size = new Size(142, 28);
            cbProgresses.TabIndex = 17;
            toolTip1.SetToolTip(cbProgresses, "Length");
            // 
            // cbOrders
            // 
            cbOrders.FormattingEnabled = true;
            cbOrders.Location = new Point(177, 60);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new Size(151, 28);
            cbOrders.TabIndex = 0;
            toolTip1.SetToolTip(cbOrders, "Length");
            cbOrders.SelectionChangeCommitted += cbOrders_SelectionChangeCommitted;
            cbOrders.Validating += cbOrders_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(177, 25);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 4;
            label4.Text = "Chọn đơn hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dtOrderDate);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(mOrderTime);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(424, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 119);
            panel2.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 47);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 21;
            label11.Text = "Ngày/tháng/năm";
            // 
            // dtOrderDate
            // 
            dtOrderDate.CustomFormat = "dd/MM/yyyy";
            dtOrderDate.Format = DateTimePickerFormat.Custom;
            dtOrderDate.Location = new Point(13, 76);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(123, 27);
            dtOrderDate.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(157, 47);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 20;
            label12.Text = "Giờ:phút:giây";
            // 
            // mOrderTime
            // 
            mOrderTime.Enabled = false;
            mOrderTime.Location = new Point(157, 76);
            mOrderTime.Mask = "00:00:00";
            mOrderTime.Name = "mOrderTime";
            mOrderTime.Size = new Size(125, 27);
            mOrderTime.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(98, 11);
            label13.Name = "label13";
            label13.Size = new Size(100, 23);
            label13.TabIndex = 19;
            label13.Text = "ĐẶT HÀNG";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dtReceiveDate);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(mReceiveTime);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(725, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 119);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 47);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 21;
            label5.Text = "Giờ:phút:giây";
            // 
            // dtReceiveDate
            // 
            dtReceiveDate.CustomFormat = "dd/MM/yyyy";
            dtReceiveDate.Format = DateTimePickerFormat.Custom;
            dtReceiveDate.Location = new Point(14, 74);
            dtReceiveDate.Name = "dtReceiveDate";
            dtReceiveDate.Size = new Size(123, 27);
            dtReceiveDate.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 47);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 20;
            label6.Text = "Ngày/tháng/năm";
            // 
            // mReceiveTime
            // 
            mReceiveTime.Enabled = false;
            mReceiveTime.Location = new Point(152, 74);
            mReceiveTime.Mask = "00:00:00";
            mReceiveTime.Name = "mReceiveTime";
            mReceiveTime.Size = new Size(125, 27);
            mReceiveTime.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(96, 11);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 19;
            label7.Text = "GIAO HÀNG";
            // 
            // panel4
            // 
            panel4.Controls.Add(btCancel);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(btAddOrderDetail);
            panel4.Controls.Add(mPrice);
            panel4.Controls.Add(mQuantity);
            panel4.Controls.Add(cbProducts);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(30, 217);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 75);
            panel4.TabIndex = 5;
            // 
            // btCancel
            // 
            btCancel.CausesValidation = false;
            btCancel.Location = new Point(630, 34);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(94, 29);
            btCancel.TabIndex = 4;
            btCancel.Text = "Hủy";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(385, 13);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 8;
            label8.Text = "Đơn giá";
            // 
            // btAddOrderDetail
            // 
            btAddOrderDetail.Location = new Point(525, 34);
            btAddOrderDetail.Name = "btAddOrderDetail";
            btAddOrderDetail.Size = new Size(94, 29);
            btAddOrderDetail.TabIndex = 5;
            btAddOrderDetail.Text = "Thêm";
            btAddOrderDetail.UseVisualStyleBackColor = true;
            btAddOrderDetail.Click += btAddOrderDetail_Click;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(385, 37);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(125, 27);
            mPrice.TabIndex = 3;
            toolTip1.SetToolTip(mPrice, "Length");
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(242, 36);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(125, 27);
            mQuantity.TabIndex = 2;
            toolTip1.SetToolTip(mQuantity, "Length");
            mQuantity.TypeValidationCompleted += mQuantity_TypeValidationCompleted;
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(14, 36);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(209, 28);
            cbProducts.TabIndex = 1;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            cbProducts.Validating += cbProducts_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(242, 13);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 4;
            label9.Text = "Số lượng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 13);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 2;
            label10.Text = "Chọn sản phẩm";
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(908, 372);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 7;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(908, 315);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 7;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbCustomers
            // 
            cbCustomers.Enabled = false;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(30, 44);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(334, 28);
            cbCustomers.TabIndex = 10;
            toolTip1.SetToolTip(cbCustomers, "Length");
            // 
            // txtReceiveAddress
            // 
            txtReceiveAddress.Enabled = false;
            txtReceiveAddress.Location = new Point(377, 44);
            txtReceiveAddress.Name = "txtReceiveAddress";
            txtReceiveAddress.Size = new Size(635, 27);
            txtReceiveAddress.TabIndex = 18;
            toolTip1.SetToolTip(txtReceiveAddress, "Length");
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "DataGridView";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete, OrderDetailID, Name, OrderID, ProductID, Quantity, Price, Amount });
            dataGridView1.Location = new Point(106, 315);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(782, 127);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
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
            // OrderDetailID
            // 
            OrderDetailID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderDetailID.DataPropertyName = "OrderDetailID";
            OrderDetailID.HeaderText = "OrderDetailID";
            OrderDetailID.MinimumWidth = 6;
            OrderDetailID.Name = "OrderDetailID";
            OrderDetailID.Width = 131;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 78;
            // 
            // OrderID
            // 
            OrderID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "OrderID";
            OrderID.MinimumWidth = 8;
            OrderID.Name = "OrderID";
            OrderID.Width = 91;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.DataPropertyName = "ProductID";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            ProductID.DefaultCellStyle = dataGridViewCellStyle1;
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.ToolTipText = "Length";
            ProductID.Width = 104;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.ToolTipText = "Length";
            Quantity.Width = 94;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            Price.DefaultCellStyle = dataGridViewCellStyle3;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ToolTipText = "Length";
            Price.Width = 70;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.ToolTipText = "Length";
            Amount.Width = 91;
            // 
            // fProcessOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 453);
            Controls.Add(dataGridView1);
            Controls.Add(txtReceiveAddress);
            Controls.Add(cbCustomers);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            
            Text = "Xử lý chi tiết đơn hàng";
            WindowState = FormWindowState.Maximized;
            FormClosing += fProcessOrderDetails_FormClosing;
            Load += fProcessOrderDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private ComboBox cbOrders;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private Button btClose;
        private Button btSave;
        private ComboBox cbCustomers;
        private ComboBox cbProgresses;
        private TextBox txtReceiveAddress;
        private DateTimePicker dtReceiveDate;
        private MaskedTextBox mReceiveTime;
        private DateTimePicker dtOrderDate;
        private MaskedTextBox mOrderTime;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
        private ComboBox cbProducts;
        private Label label8;
        private MaskedTextBox mPrice;
        private MaskedTextBox mQuantity;
        private Button btCancel;
        private Button btAddOrderDetail;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn OrderDetailID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
    }
}