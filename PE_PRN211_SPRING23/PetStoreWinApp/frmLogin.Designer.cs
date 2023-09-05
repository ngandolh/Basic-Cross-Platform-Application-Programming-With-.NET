namespace PetStoreWinApp
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
            lbUserName = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtUser = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            bntLogin = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new System.Drawing.Point(90, 92);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new System.Drawing.Size(78, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "UserName";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(98, 137);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new System.Drawing.Point(211, 85);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(216, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(211, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(216, 27);
            txtPassword.TabIndex = 3;
            // 
            // bntLogin
            // 
            bntLogin.Location = new System.Drawing.Point(211, 184);
            bntLogin.Name = "bntLogin";
            bntLogin.Size = new System.Drawing.Size(94, 29);
            bntLogin.TabIndex = 4;
            bntLogin.Text = "Login";
            bntLogin.UseVisualStyleBackColor = true;
            bntLogin.Click += bntLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(333, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 282);
            Controls.Add(btnCancel);
            Controls.Add(bntLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}