using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlot3
{
    class OutDemo
    {
        static void Enroll(out Student student)
        {
            student = new Student(); // cần khởi tạo biến
            student.Gender = false;
            student.Name = "Michael";
        }

        static void MyMethod(int a, ref int b, out int c)
        {
            a = 4;
            b = 5;
            c = 6;
        }

        static void Main()
        {
            Student student;
            Enroll(out student); // không khởi tạo biến, dùng biến này làm tham số out của hàm
            Console.WriteLine($"{student.Gender} - {student.Name}" );
        }
    }
}
