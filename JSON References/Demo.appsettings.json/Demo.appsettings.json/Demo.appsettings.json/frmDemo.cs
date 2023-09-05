using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;


namespace Demo.appsettings.json
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<DefaultAccountSettings>();
            string email = adminDefaultSettings.Email;
            string password = adminDefaultSettings.Password;
            string role = adminDefaultSettings.Role;
            MessageBox.Show(email + " - " + password);

            var memberDefaultSettings = Program.Configuration.GetSection("MemberAccount").Get<DefaultAccountSettings>();
            email = memberDefaultSettings.Email;
            password = memberDefaultSettings.Password;
            role = memberDefaultSettings.Role;
            MessageBox.Show(email + " - " + password);
        }
    }
}
