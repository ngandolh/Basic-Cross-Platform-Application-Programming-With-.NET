using BusinessObject;
using Repositorices;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectManagementWinApp_TRANTHIKIMNGAN
{
    public partial class frmProjectManagement : Form
    {
        IProjectRepository projectRepository = new ProjectRepository();
        BindingSource source;
        public frmProjectManagement()
        {
            InitializeComponent();
        }


        private void frmProjectManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            //Register this event to open the frmProjectList form that performs updating 
            dgvProjectList.CellDoubleClick += DgvProjectList_CellDoubleClick;
        }

        private void DgvProjectList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProjectDetail frmProjectDetail = new frmProjectDetail
            {
                Text = "Update project",
                InsertOrUpdate = true, // Update
                ProjectInfo = GetProjectObject(),
                ProjectRepository = projectRepository
            };
            if (frmProjectDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProjectList();
                //Set focus car updated 
                source.Position = source.Count - 1;
            }
        }


        //Clear text on TextBoxes
        private void ClearText()
        {
            txtProjectID.Text = string.Empty;
            txtProjectName.Text = string.Empty;
            txtEstimatedStartDate.Text = string.Empty;
            txtEstimatedEndDate.Text = string.Empty;
            txtProjectAddress.Text = string.Empty;
            txtProjectCity.Text = string.Empty;
            txtProjectDescription.Text = string.Empty;
        }

        private ProjectObject GetProjectObject()
        {
            ProjectObject projectObject = null;
            try
            {
                projectObject = new ProjectObject
                {
                    ProjectID = int.Parse(txtProjectID.Text),
                    ProjectName = txtProjectName.Text,
                    ProjectAddress = txtProjectAddress.Text,
                    ProjectCity = txtProjectCity.Text,
                    ProjectDescription = txtProjectDescription.Text,
                    EstimatedEndDate = DateTime.Now,
                    EstimatedStartDate = DateTime.Now,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get project");
            }
            return projectObject;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProjectList();
        }

        private void LoadProjectList()
        {
            var pro = projectRepository.GetProjectObjects();
            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = pro;

                txtProjectID.DataBindings.Clear();
                txtProjectName.DataBindings.Clear();
                txtEstimatedStartDate.DataBindings.Clear();
                txtEstimatedEndDate.DataBindings.Clear();
                txtProjectAddress.DataBindings.Clear();
                txtProjectCity.DataBindings.Clear();
                txtProjectDescription.DataBindings.Clear();

                txtProjectID.DataBindings.Add("Text", source, "ProjectID");
                txtProjectName.DataBindings.Add("Text", source, "ProjectName");
                txtEstimatedStartDate.DataBindings.Add("Text", source, "EstimatedStartDate");
                txtEstimatedEndDate.DataBindings.Add("Text", source, "EstimatedEndDate");
                txtProjectAddress.DataBindings.Add("Text", source, "ProjectAddress");
                txtProjectCity.DataBindings.Add("Text", source, "ProjectCity");
                txtProjectDescription.DataBindings.Add("Text", source, "ProjectDescription");

                dgvProjectList.DataSource = null;
                dgvProjectList.DataSource = source;
                if (pro.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
            //frmCarDetails frmCarDetails = new frmCarDetails
            //{
            //    Text = "Add car",
            //    InsertOrUpdate = false,
            //    CarRepository = carRepository
            //};
            //if (frmCarDetails.ShowDialog() == DialogResult.OK)
            //{
            LoadProjectList();
            //Set focus car inserted 
            source.Position = source.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var pro = GetProjectObject();
                projectRepository.DeleteProject(pro.ProjectID);
                LoadProjectList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a project");
            }
        }
    }
}
