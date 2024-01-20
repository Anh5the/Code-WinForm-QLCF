namespace QLBH
{
    partial class fForget
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
            btClose = new Button();
            btForget = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblMessage = new Label();
            label1 = new Label();
            txtRePassword = new TextBox();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(296, 312);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 44;
            btClose.Text = "Quay lại";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btForget
            // 
            btForget.Location = new Point(271, 268);
            btForget.Name = "btForget";
            btForget.Size = new Size(148, 29);
            btForget.TabIndex = 43;
            btForget.Text = "Đổi mật khẩu mới";
            btForget.UseVisualStyleBackColor = true;
            btForget.Click += btForget_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(271, 164);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(148, 27);
            txtPassword.TabIndex = 41;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(271, 120);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 27);
            txtEmail.TabIndex = 40;
            txtEmail.Validating += txtUser_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(138, 167);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 47;
            label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(162, 123);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 46;
            label3.Text = "Email";
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Location = new Point(138, 71);
            lblMessage.Margin = new Padding(2, 0, 2, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(419, 32);
            lblMessage.TabIndex = 46;
            lblMessage.Text = "Hãy nhập thông tin";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(271, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 45;
            label1.Text = "Quên mật khẩu";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(271, 207);
            txtRePassword.Margin = new Padding(2);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.PasswordChar = '*';
            txtRePassword.Size = new Size(148, 27);
            txtRePassword.TabIndex = 42;
            txtRePassword.Validating += txtRePass_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(126, 210);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 49;
            label2.Text = "Nhập lại mật khẩu";
            // 
            // fForget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 360);
            ControlBox = false;
            Controls.Add(txtRePassword);
            Controls.Add(label2);
            Controls.Add(btClose);
            Controls.Add(btForget);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblMessage);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "fForget";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu";
            FormClosing += fForget_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btClose;
        private Button btForget;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label lblMessage;
        private Label label1;
        private TextBox txtRePassword;
        private Label label2;
        private ToolTip toolTip1;
    }
}