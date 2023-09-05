using AutomobileLibrary.Repository;
using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomobileWinApp;

namespace AutomobileWinAp
{
    public partial class frmCarManagement : Form
    {
        ICarRepository carRepository = new CarRepository();
        //Create a data source
        BindingSource source;
        public frmCarManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            //Register this event to open the frmCarDetails form that performs updating
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleCick;
        }

        private void dgvCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails()
            {
                Text = "Update car";
                
            }
        }
        //------------------------------------------------------

    }
}
