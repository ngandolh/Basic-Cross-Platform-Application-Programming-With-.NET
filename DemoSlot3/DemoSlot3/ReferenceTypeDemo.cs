using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlot3
{
    class ReferenceTypeDemo
    {
        static void Enroll(ref Student student)
        {
            student.Gender = true;
            student = new Student();
            student.Name = "Van";
            student.Gender = false;
        }
        static void IncrementExample(ref int num)
        {
            num = num + 1;
        }
        static void Main()
        {
            var student = new Student
            {
                Name = "John",
                Gender = false
            };
            Enroll(ref student);
            
            Console.WriteLine(student.Name);

            int num = 1;
            IncrementExample(ref num);
            // num is now 2
            Console.WriteLine(num);
        }
    }
}
