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
    public partial class frmListViewDemo : Form
    {
        public frmListViewDemo()
        {
            InitializeComponent();
        }

        private void frmListViewDemo_Load(object sender, EventArgs e)
        {
        }

        private void rdLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            lvData.View = View.LargeIcon;
        }

        private void rdDetails_CheckedChanged(object sender, EventArgs e)
        {
            lvData.View = View.Details;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(txtID.Text);
            lv1.SubItems.Add(txtName.Text);
            lv1.SubItems.Add(txtAddress.Text);
            lvData.Items.Add(lv1);
        }
    }
}
