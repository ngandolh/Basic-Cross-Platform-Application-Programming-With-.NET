using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using CarContracts_StudentName_LIB.Repo;
using CarContracts_StudentName_LIB.Models;

namespace PRN211PE_FALL22_StudentFullName_
{
    public partial class ManagementForm : Form
    {
        IContactRepo customerAccounts = new ContactRepo();
        
        public BindingSource? source;
        public ManagementForm()
        {
            InitializeComponent();
        }
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            List<Contract> list = customerAccounts.getAll();
            LoadList(list);
        }
        private void LoadList(List<Contract> list)
        {
            try
            {
                

                source = new BindingSource();
                source.DataSource = list;
                

                dgvListCusAccount.DataSource = null;
                dgvListCusAccount.DataSource = source;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Contract> list = customerAccounts.getByRegion(txtSearch.Text);
            LoadList(list);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //DetailForm frmDetail = new DetailForm()
            //{
            //    Text = "Add",
            //    InsertOrUpdate = false,
            //    CustomerAccountsRepo = customerAccounts

            //};
            //frmDetail.ShowDialog();
            //List<CustomerAccount> list = customerAccounts.getAll();
            //    LoadList(list);
            //    source.Position = source.Count - 1;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            customerAccounts.remove(GetObject().ContractId);
            List<Contract> list = customerAccounts.getAll();
            LoadList(list);
        }
        private Contract GetObject()
        {
            Contract? a = null;
            try
            {
                a = (Contract) dgvListCusAccount.CurrentRow.DataBoundItem;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get fail!");
            }
            return a;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to cancel ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvListCusAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DetailForm frmDetail = new DetailForm()
            //{
            //    Text = "Update ",
            //    InsertOrUpdate = true,
            //    Info = GetObject(),
            //    CustomerAccountsRepo = customerAccounts
            //};
            //frmDetail.ShowDialog();
            //    List<CustomerAccount> list = customerAccounts.getAll();
            //    LoadList(list);
            //    //
            //    source.Position = source.Count - 1;
            
        }
    }
}
