using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlot3
{
    class InDemo
    {
        static void Enroll(in Student student)
        {
            student.Gender = true;
        }


        static void Main()
        {
            var student = new Student
            {
                Name = "John",
                Gender = false
            };
            Enroll(student);
            Console.WriteLine(student);

        }
    }
}
