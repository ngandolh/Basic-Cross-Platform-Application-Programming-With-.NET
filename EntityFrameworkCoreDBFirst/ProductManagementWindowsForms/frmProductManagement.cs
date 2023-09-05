using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementWindowsForms
{
    public partial class frmProductManagement : Form
    {
        IProductRepository repository = new ProductRepository();
        public frmProductManagement()
        {
            InitializeComponent();
        }

        public void LoadCategoryList()
        {
            try
            {
                var categoryList = repository.GetCategories();
                cboCategory.DataSource = categoryList;
                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "CategoryId";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }
        public void LoadProductList()
        {
            try
            {
                var productList = repository.GetProducts();
                BindingSource source = new BindingSource();
                source.DataSource = productList;

                txtProductId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                cboCategory.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsinStock");
                cboCategory.DataBindings.Add("Text", source, "Category.CategoryName");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            LoadProductList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create")
            {
                btnCreate.Text = "Cancel";
                btnSave.Enabled = true;
                // Clear DataBinding
                txtProductId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                cboCategory.DataBindings.Clear();
                dgvProducts.ClearSelection();
                ClearText();
            }
            else
            {
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadProductList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtUnitPrice.Text == "" || txtUnitsInStock.Text == "")
            {
                MessageBox.Show("All fields are required!", "Product Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Product
                {
                    //ProductId = int.Parse(txtProductId.Text),
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = short.Parse(txtUnitsInStock.Text),
                    CategoryId = int.Parse(cboCategory.SelectedValue.ToString())
                };
                repository.SaveProduct(p);

                btnCreate.Text = "Create";
                btnSave.Enabled = false;

                LoadProductList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtUnitPrice.Text == "" || txtUnitsInStock.Text == "")
            {
                MessageBox.Show("All fields are required!", "Product Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = short.Parse(txtUnitsInStock.Text),
                    CategoryId = int.Parse(cboCategory.SelectedValue.ToString())

                };
                repository.UpdateProduct(p);

                LoadProductList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Product Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var p = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                };
                repository.DeleteProduct(p);
                LoadProductList();
            }
        }
        private void ClearText()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";
            txtUnitsInStock.Text = "";
            cboCategory.SelectedIndex = 0;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
