namespace QLBH
{
    partial class fLogin
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btClose = new Button();
            btLogin = new Button();
            liForget = new LinkLabel();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 36;
            label1.Text = "Đăng nhập hệ thống";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(160, 125);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 38;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(154, 171);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 39;
            label4.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(268, 122);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(268, 169);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(148, 27);
            txtPassword.TabIndex = 1;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(286, 269);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 3;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(286, 222);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(94, 29);
            btLogin.TabIndex = 2;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // liForget
            // 
            liForget.AutoSize = true;
            liForget.Location = new Point(154, 226);
            liForget.Name = "liForget";
            liForget.Size = new Size(109, 20);
            liForget.TabIndex = 44;
            liForget.TabStop = true;
            liForget.Text = "Quên mật khẩu";
            liForget.LinkClicked += liForget_LinkClicked;
            // 
            // lblMessage
            // 
            lblMessage.FlatStyle = FlatStyle.System;
            lblMessage.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Location = new Point(145, 71);
            lblMessage.Margin = new Padding(2, 0, 2, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(385, 25);
            lblMessage.TabIndex = 37;
            lblMessage.Text = "Chào Bạn!";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 360);
            Controls.Add(liForget);
            Controls.Add(btClose);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblMessage);
            Controls.Add(label1);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btClose;
        private Button btLogin;
        private LinkLabel liForget;
        private Label lblMessage;
    }
}