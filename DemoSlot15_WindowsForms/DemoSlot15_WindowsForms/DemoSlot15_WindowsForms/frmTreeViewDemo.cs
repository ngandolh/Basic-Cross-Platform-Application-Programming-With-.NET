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
    public partial class frmTreeViewDemo : Form
    {
        public frmTreeViewDemo()
        {
            InitializeComponent();
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (tvData.SelectedNode == null)
            {
                tvData.Nodes.Add(txtNodeName.Text);
            }
            else
            {
                tvData.SelectedNode.Nodes.Add(txtNodeName.Text);
            }
            
        }
    }
}
