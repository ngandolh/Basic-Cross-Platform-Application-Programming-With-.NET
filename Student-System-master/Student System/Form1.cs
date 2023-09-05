using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Student
        {
            public string adress;
            public int id;
            public string name;
            public string job;
            public string phone;
        };
        public List<Student> StudentList = new List<Student>();

        private void Add_Button_Click(object sender, EventArgs e)
        {

            int temp = 0;
            bool less = false;
            Student x;
            x.id = Int32.Parse(ID_Box.Text);
            x.name = Name_Box.Text;
            x.adress = Address_Box.Text;
            x.phone = Phone_Box.Text;
            x.job = Job_Box.Text;
            if (!StudentList.Any())
            {
                StudentList.Add(x);
                ID_Box.Clear();
                Address_Box.Clear();
                Name_Box.Clear();
                Phone_Box.Clear();
                Job_Box.Clear();
            }

            else
            {
                foreach (Student s in StudentList)
                {
                    if (x.id < s.id)
                    {
                        temp = StudentList.IndexOf(s);
                        less = true;
                        break;
                    }

                }
                if (less == true)
                {
                    StudentList.Insert(temp, x);
                    less = false;
                    ID_Box.Clear();
                    Address_Box.Clear();
                    Phone_Box.Clear();
                    Name_Box.Clear();
                    Job_Box.Clear();
                }
                else
                {
                    StudentList.Add(x);
                    ID_Box.Clear();
                    Address_Box.Clear();
                    Name_Box.Clear();
                    Phone_Box.Clear();
                    Job_Box.Clear();
                }
            }

        }

        private void Display_Button_Click(object sender, EventArgs e)
        {     
            foreach (Student iteam in StudentList)
            {
                Display_list.Text += "ID=" + iteam.id + "\t Name=" + iteam.name + "\n Adress is  " + iteam.adress + "\t Phone:  " + iteam.phone + "\n" + "\t Job=" + iteam.job+"\n";
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("d:\\MeGzz.txt");
            foreach (Student iteam in StudentList)
            {
                sr.WriteLine("ID=" + iteam.id + "\t Name=" + iteam.name + "\n Adress:" + iteam.adress + "\t phone=" + iteam.phone + "\t job=" + iteam.job);
            }
            sr.Close();
        }

        private void SearchName_Button_Click(object sender, EventArgs e)
        {
            if (Name_Box.Text == "")
            {
                MessageBox.Show("Write Student Name ");
            }
            else
            {
                bool flag = false;
                foreach (Student s in StudentList)
                {
                    if (Name_Box.Text == s.name)
                    {
                        MessageBox.Show("Found at  " + StudentList.IndexOf(s) + "\t ID=" + s.id);
                        flag = true;
                    }
                }
                if (!flag && Name_Box.Text != "")
                {
                    MessageBox.Show("Not Found !");

                }
            }
        }

        private void SearchID_Button_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Student s in StudentList)
            {
                if (int.Parse(ID_Box.Text) == s.id)
                {
                    MessageBox.Show("Found at  " + StudentList.IndexOf(s) + "\t name=" + s.name);
                    flag = true;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Not Found !");

            }

        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            StudentList.Clear();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            foreach (Student iteam in StudentList)
            {
                if (Int32.Parse(ID_Box.Text) == iteam.id)
                {
                    StudentList.RemoveAt(StudentList.IndexOf(iteam));
                    MessageBox.Show("Done !");
                    break;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
