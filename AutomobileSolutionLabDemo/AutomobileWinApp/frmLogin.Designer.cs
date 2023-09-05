namespace AutomobileWinApp
{
    partial class frmLogin
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
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(195, 96);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(190, 142);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(324, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(125, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(324, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(125, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(326, 204);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(477, 204);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(94, 29);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
    }
}