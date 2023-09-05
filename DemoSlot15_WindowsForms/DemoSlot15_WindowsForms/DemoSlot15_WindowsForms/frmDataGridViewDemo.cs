using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSlot15_WindowsForms
{
    public partial class frmDataGridViewDemo : Form
    {
        public frmDataGridViewDemo()
        {
            InitializeComponent();
        }
        List<dynamic> productList = new List<dynamic> {
                new { ProductID=3, ProductName="Cake", ProductPrice=12.23},
                new { ProductID=4, ProductName="Apple", ProductPrice=45.23},
                new { ProductID=3, ProductName="Orange", ProductPrice=78.5}
            };

        private void btnList_Click(object sender, EventArgs e)
        {            
            dgvProducts.DataSource = productList;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            DataTable productTable = new DataTable();
            productTable.Columns.Add("ProductID", typeof(int));
            productTable.Columns.Add("ProductName", typeof(string));
            productTable.Columns.Add("ProductPrice", typeof(decimal));

            foreach (var tmp in productList)
            {
                productTable.Rows.Add(tmp.ProductID, tmp.ProductName, tmp.ProductPrice);
            }

            dgvProducts.DataSource = productTable;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
