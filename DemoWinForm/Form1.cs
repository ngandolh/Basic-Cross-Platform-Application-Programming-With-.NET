using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + BtnName.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load Event");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing event");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember();
            //frmMember.Show(); //mỗi lần nhấn là new 1 cửa sổ
            frmMember.ShowDialog(); //Chỉ new 1 lần duy nhất
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listDegree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
