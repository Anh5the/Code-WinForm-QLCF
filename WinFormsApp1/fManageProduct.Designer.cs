namespace QLBH
{
    partial class fManageProduct
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            btNew = new Button();
            label1 = new Label();
            txtName = new TextBox();
            btFind = new Button();
            dataGridView1 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            MarketPrice = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ImageFile = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label3 = new Label();
            cbCategories = new ComboBox();
            ckCategory = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(211, 9);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 5;
            label2.Text = "QUẢN LÝ SẢN PHẨM";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btNew
            // 
            btNew.Location = new Point(22, 53);
            btNew.Margin = new Padding(2);
            btNew.Name = "btNew";
            btNew.Size = new Size(90, 27);
            btNew.TabIndex = 5;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên sản phẩm";
            // 
            // txtName
            // 
            txtName.Location = new Point(591, 13);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 27);
            txtName.TabIndex = 2;
            // 
            // btFind
            // 
            btFind.Location = new Point(807, 13);
            btFind.Margin = new Padding(2);
            btFind.Name = "btFind";
            btFind.Size = new Size(90, 27);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Quantity, Price, MarketPrice, Description, ImageFile, Status, Edit, Delete });
            dataGridView1.Location = new Point(22, 100);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(898, 271);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.DataPropertyName = "ProductID";
            ProductID.Frozen = true;
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 8;
            ProductID.Name = "ProductID";
            ProductID.Width = 104;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductName.DataPropertyName = "Name";
            ProductName.Frozen = true;
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.Width = 78;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            Quantity.DefaultCellStyle = dataGridViewCellStyle1;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 94;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 70;
            // 
            // MarketPrice
            // 
            MarketPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MarketPrice.DataPropertyName = "MarketPrice";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            MarketPrice.DefaultCellStyle = dataGridViewCellStyle3;
            MarketPrice.HeaderText = "MarketPrice";
            MarketPrice.MinimumWidth = 8;
            MarketPrice.Name = "MarketPrice";
            MarketPrice.Width = 116;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.Width = 114;
            // 
            // ImageFile
            // 
            ImageFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ImageFile.DataPropertyName = "ImageFile";
            ImageFile.HeaderText = "ImageFile";
            ImageFile.MinimumWidth = 8;
            ImageFile.Name = "ImageFile";
            ImageFile.Resizable = DataGridViewTriState.True;
            ImageFile.Width = 103;
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
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 41;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 53);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 11;
            label3.Text = "Chọn loại";
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(244, 52);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(205, 28);
            cbCategories.TabIndex = 0;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // ckCategory
            // 
            ckCategory.AutoSize = true;
            ckCategory.CheckAlign = ContentAlignment.MiddleRight;
            ckCategory.Checked = true;
            ckCategory.CheckState = CheckState.Checked;
            ckCategory.Location = new Point(591, 56);
            ckCategory.Name = "ckCategory";
            ckCategory.Size = new Size(231, 24);
            ckCategory.TabIndex = 4;
            ckCategory.Text = "Tìm theo loại sản phẩm và tên";
            ckCategory.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(977, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // fManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 382);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(ckCategory);
            Controls.Add(cbCategories);
            Controls.Add(label3);
            Controls.Add(btFind);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btNew);
            Controls.Add(label2);
            Name = "fManageProduct";
            Text = "Quản lý sản phẩm";
            WindowState = FormWindowState.Maximized;
            Activated += fManageProduct_Activated;
            Load += fManageProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btNew;
        private Label label1;
        private TextBox txtName;
        private Button btFind;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox cbCategories;
        private CheckBox ckCategory;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn MarketPrice;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ImageFile;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}