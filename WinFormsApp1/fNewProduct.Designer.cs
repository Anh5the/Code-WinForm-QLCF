namespace QLBH
{
    partial class fNewProduct
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
            rDescription = new RichTextBox();
            txtName = new TextBox();
            txtImageFile = new TextBox();
            label3 = new Label();
            label4 = new Label();
            mQuantity = new MaskedTextBox();
            mPrice = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ckStatus = new CheckBox();
            cbCategories = new ComboBox();
            btSave = new Button();
            btClose = new Button();
            btBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            mMarketPrice = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 8;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 103);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 9;
            label2.Text = "Tập tin hình";
            // 
            // rDescription
            // 
            rDescription.Location = new Point(130, 107);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(218, 120);
            rDescription.TabIndex = 6;
            rDescription.Text = "";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(426, 27);
            txtName.TabIndex = 0;
            toolTip1.SetToolTip(txtName, "Length");
            txtName.Validating += txtName_Validating;
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(469, 100);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(125, 27);
            txtImageFile.TabIndex = 7;
            toolTip1.SetToolTip(txtImageFile, "Length");
            txtImageFile.Validating += txtImageFile_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 59);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 13;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 107);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 14;
            label4.Text = "Mô tả ngắn";
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(132, 59);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(125, 27);
            mQuantity.TabIndex = 3;
            toolTip1.SetToolTip(mQuantity, "Length");
            mQuantity.TypeValidationCompleted += mQuantity_TypeValidationCompleted;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(376, 59);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(125, 27);
            mPrice.TabIndex = 4;
            toolTip1.SetToolTip(mPrice, "Length");
            mPrice.TypeValidationCompleted += mPrice_TypeValidationCompleted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 62);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 17;
            label5.Text = "Giá bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(578, 17);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 18;
            label6.Text = "Loại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 62);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 19;
            label7.Text = "Giá thị trường";
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(789, 17);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 2;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(624, 17);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(151, 28);
            cbCategories.TabIndex = 1;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // btSave
            // 
            btSave.Location = new Point(789, 132);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(789, 178);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(600, 100);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(45, 29);
            btBrowse.TabIndex = 8;
            btBrowse.Text = "...";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // mMarketPrice
            // 
            mMarketPrice.Location = new Point(650, 56);
            mMarketPrice.Name = "mMarketPrice";
            mMarketPrice.Size = new Size(125, 27);
            mMarketPrice.TabIndex = 5;
            toolTip1.SetToolTip(mMarketPrice, "Length");
            mMarketPrice.TypeValidationCompleted += mMarketPrice_TypeValidationCompleted;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(651, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // fNewProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 239);
            ControlBox = false;
            Controls.Add(mMarketPrice);
            Controls.Add(pictureBox1);
            Controls.Add(btBrowse);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(cbCategories);
            Controls.Add(ckStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(mPrice);
            Controls.Add(mQuantity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtImageFile);
            Controls.Add(txtName);
            Controls.Add(rDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fNewProduct";
            Text = "Nhập thêm sản phẩm mới";
            WindowState = FormWindowState.Maximized;
            FormClosing += fNewProduct_FormClosing;
            Load += fNewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox rDescription;
        private TextBox txtName;
        private TextBox txtImageFile;
        private Label label3;
        private Label label4;
        private MaskedTextBox mQuantity;
        private MaskedTextBox mPrice;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox ckStatus;
        private ComboBox cbCategories;
        private Button btSave;
        private Button btClose;
        private Button btBrowse;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private MaskedTextBox mMarketPrice;
    }
}