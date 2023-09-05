using CarContracts_StudentName_LIB.Models;
using CarContracts_StudentName_LIB.Repo;
using PRN211PE_FALL22_StudentFullName_;

namespace CarContracts_StudentName
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public IUsersRepo UsersRepo { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text) && string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                DialogResult dg = MessageBox.Show("Please input user name and password", "Login Noti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string userName = txtUserName.Text;
                    string password = txtPass.Text;
                    UsersRepo = new UsersRepo();
                    User user = UsersRepo.checkLogin(userName, password);
                    if (user != null)
                    {
                        if (user.UserRole == 1)
                        {
                            DialogResult dg = MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ManagementForm frmMana = new ManagementForm();
                            frmMana.Show();
                            this.Hide();
                        }
                        else
                        {
                            DialogResult dg = MessageBox.Show("You are not allowed to access this function!", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to cancel ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}