namespace QLBH
{
    partial class fEditProduct
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
            mMarketPrice = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            btBrowse = new Button();
            btClose = new Button();
            btSave = new Button();
            cbCategories = new ComboBox();
            ckStatus = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            mPrice = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            txtImageFile = new TextBox();
            txtName = new TextBox();
            rDescription = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            mQuantity = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mMarketPrice
            // 
            mMarketPrice.Location = new Point(818, 68);
            mMarketPrice.Margin = new Padding(4, 4, 4, 4);
            mMarketPrice.Name = "mMarketPrice";
            mMarketPrice.Size = new Size(155, 31);
            mMarketPrice.TabIndex = 32;
            toolTip1.SetToolTip(mMarketPrice, "Length");
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(819, 121);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(755, 122);
            btBrowse.Margin = new Padding(4, 4, 4, 4);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(56, 36);
            btBrowse.TabIndex = 36;
            btBrowse.Text = "...";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(991, 220);
            btClose.Margin = new Padding(4, 4, 4, 4);
            btClose.Name = "btClose";
            btClose.Size = new Size(118, 36);
            btClose.TabIndex = 39;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(991, 162);
            btSave.Margin = new Padding(4, 4, 4, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 36);
            btSave.TabIndex = 38;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(785, 19);
            cbCategories.Margin = new Padding(4, 4, 4, 4);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(188, 33);
            cbCategories.TabIndex = 28;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(991, 19);
            ckStatus.Margin = new Padding(4, 4, 4, 4);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(115, 29);
            ckStatus.TabIndex = 29;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(685, 75);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 44;
            label7.Text = "Giá thị trường";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(728, 19);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 43;
            label6.Text = "Loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 75);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 42;
            label5.Text = "Giá bán";
            // 
            // mPrice
            // 
            mPrice.Location = new Point(475, 71);
            mPrice.Margin = new Padding(4, 4, 4, 4);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(155, 31);
            mPrice.TabIndex = 31;
            toolTip1.SetToolTip(mPrice, "Length");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 131);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 41;
            label4.Text = "Mô tả ngắn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 71);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 40;
            label3.Text = "Số lượng";
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(591, 122);
            txtImageFile.Margin = new Padding(4, 4, 4, 4);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(155, 31);
            txtImageFile.TabIndex = 34;
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 15);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(532, 31);
            txtName.TabIndex = 27;
            toolTip1.SetToolTip(txtName, "Length");
            // 
            // rDescription
            // 
            rDescription.Location = new Point(168, 131);
            rDescription.Margin = new Padding(4, 4, 4, 4);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(272, 149);
            rDescription.TabIndex = 33;
            rDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 37;
            label2.Text = "Tập tin hình";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 35;
            label1.Text = "Tên sản phẩm";
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(170, 71);
            mQuantity.Margin = new Padding(4);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(155, 31);
            mQuantity.TabIndex = 30;
            toolTip1.SetToolTip(mQuantity, "Length");
            // 
            // fEditProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 292);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "fEditProduct";
            Text = "Sửa đổi Sản phẩm";
            FormClosing += fEditProduct_FormClosing;
            Load += fEditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mMarketPrice;
        private PictureBox pictureBox1;
        private Button btBrowse;
        private Button btClose;
        private Button btSave;
        private ComboBox cbCategories;
        private CheckBox ckStatus;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaskedTextBox mPrice;
        private Label label4;
        private Label label3;
        private TextBox txtImageFile;
        private TextBox txtName;
        private RichTextBox rDescription;
        private Label label2;
        private Label label1;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private MaskedTextBox mQuantity;
    }
}