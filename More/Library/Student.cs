using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Student
    {
        //private field
        int id;
        string name;

        //property
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
        }

        //viet tat cua property
        public string Name { get; set; }

        public Student()
        {
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public virtual void Display()
        {
            //3 cach in data
            Console.WriteLine("Student: Id: " + Id + ", Name: " + Name);
            Console.WriteLine($"Student: Id:{Id}, Name:{Name}");
            Console.WriteLine(String.Format("Student: Id:{0}, Name:{1}", Id, Name));
        }

        //input data
        public void Input()
        {
            Console.WriteLine("Nhap Id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Name:");
            Name = Console.ReadLine();
        }
        
        //Equal() thuộc lớp Class Object  - Master Class
        // must to overried
        public override bool Equals(object obj)
        {
            return obj is Student student &&
                Id == student.Id &&
                Name == student.Name;
        }
    }

    class SEStudent : Student
    {
        public string Skill { get; set; }

        public SEStudent()
        {
        }

        //loi goi ham tao lop cha
        public SEStudent(int id, string name, string skill) : base(id, name)
        {

            Skill = skill;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Skill:{Skill}");

        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Skill: ");
            Skill = Console.ReadLine(); 
        }


    }
}
