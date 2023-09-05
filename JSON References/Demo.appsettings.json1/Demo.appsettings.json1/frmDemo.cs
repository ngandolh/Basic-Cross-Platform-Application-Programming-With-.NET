using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.appsettings.json1
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fileName = "appsettings.json";
            string json = File.ReadAllText(fileName);  // đọc text từ tập tin JSON

            // deserialize từ chuỗi đọc ở tập tin JSOn --> đối tượng DefaultAccount
            var adminAccount = JsonSerializer.Deserialize<DefaultAccount>(json, null); 
            
            string email = adminAccount.Email;
            string password = adminAccount.Password;
            string role = adminAccount.Role;

            MessageBox.Show(email + " - " + password);
        }
    }
}
