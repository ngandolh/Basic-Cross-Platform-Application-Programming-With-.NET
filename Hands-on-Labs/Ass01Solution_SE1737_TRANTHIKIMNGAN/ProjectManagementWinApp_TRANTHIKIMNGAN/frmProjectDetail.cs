using BusinessObject;
using Repositorices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementWinApp_TRANTHIKIMNGAN
{
    public partial class frmProjectDetail : Form
    {
        public frmProjectDetail()
        {
            InitializeComponent();
        }
        public IProjectRepository ProjectRepository { get; set; }

        public bool InsertOrUpdate { get; set; }
        public ProjectObject ProjectInfo { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var project = new ProjectObject
                {
                    ProjectID = int.Parse(txtProjectID.Text),
                    ProjectName = txtProjectName.Text,
                    ProjectDescription = txtProjectDescription.Text,
                    ProjectAddress = txtProjectAddress.Text,
                    ProjectCity = txtProjectCity.Text,
                    EstimatedStartDate = DateTime.Now,
                    EstimatedEndDate = DateTime.Now,
                };
                if (InsertOrUpdate == false)
                {
                    //tạo mới
                    ProjectRepository.InsertProject(project);
                }
                else
                {
                    ProjectRepository.UpdateProject(project);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a project" : "Update a project ");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmProjectDetail_Load(object sender, EventArgs e)
        {
            //cboManufacturer.SelectedIndex = 0;
            txtProjectID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) //Update mode
            {
                //Show car to perform updating
                txtProjectID.Text = ProjectInfo.ProjectID.ToString();
                txtProjectName.Text = ProjectInfo.ProjectName.ToString();
                txtProjectAddress.Text = ProjectInfo.ProjectAddress.ToString();
                txtProjectCity.Text = ProjectInfo.ProjectCity.ToString();
                txtProjectDescription.Text = ProjectInfo.ProjectDescription.ToString();
                dtEstimatedEndDate.Text = ProjectInfo.EstimatedEndDate.ToString();
                dtEstimatedStartDate.Text = ProjectInfo.EstimatedStartDate.ToString();
            }
        }
    }
}
