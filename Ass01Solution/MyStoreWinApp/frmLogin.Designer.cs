﻿namespace MyStoreWinApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ibEmail = new System.Windows.Forms.Label();
            this.ibPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ibEmail
            // 
            this.ibEmail.AutoSize = true;
            this.ibEmail.Location = new System.Drawing.Point(24, 32);
            this.ibEmail.Name = "ibEmail";
            this.ibEmail.Size = new System.Drawing.Size(36, 15);
            this.ibEmail.TabIndex = 0;
            this.ibEmail.Text = "Email";
            // 
            // ibPassword
            // 
            this.ibPassword.AutoSize = true;
            this.ibPassword.Location = new System.Drawing.Point(24, 64);
            this.ibPassword.Name = "ibPassword";
            this.ibPassword.Size = new System.Drawing.Size(57, 15);
            this.ibPassword.TabIndex = 1;
            this.ibPassword.Text = "Password";
            this.ibPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 24);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 56);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '1';
            this.txtPassword.Size = new System.Drawing.Size(160, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(88, 88);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(72, 22);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "&Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(176, 88);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 22);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 125);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.ibPassword);
            this.Controls.Add(this.ibEmail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ibEmail;
        private Label ibPassword;
        private MaskedTextBox txtEmail;
        private MaskedTextBox txtPassword;
        private Button btnLog;
        private Button btnClose;
    }
}