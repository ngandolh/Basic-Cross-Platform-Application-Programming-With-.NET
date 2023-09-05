using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

using BusinessObject;

namespace ProjectManagementWinApp_TRANTHIKIMNGAN
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<DefaultAccountSettings>();
            string email = adminDefaultSettings.Email;
            string password = adminDefaultSettings.Password;
            string role = adminDefaultSettings.Role;
            frmProjectManagement manage = new frmProjectManagement();   
            manage.ShowDialog();
        }

    }
}
