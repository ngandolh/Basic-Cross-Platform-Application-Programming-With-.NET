using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo3Week
{
    public class Student
    {
        private int id; //Field
        private string name;//Field
        private int age;//Field
        private string address;//Field

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        } //Property

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address {get;set;}

        public Student(int id, string name, int age, string address)
        {

        }
        public bool Reg(string subjectId)
        {
            return false;
        }

        public void View()
        {

        }

    }
}
