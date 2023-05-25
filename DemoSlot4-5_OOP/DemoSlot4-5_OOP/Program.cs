using System;
using ClassLibrary;

namespace DemoSlot4_5_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations @
            try {
                using var reader = new System.IO.StreamReader(@"D:\data.txt");
                var content = reader.ReadToEnd();
                Console.WriteLine($"File length: {content.Length}");
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

            Class1 a = new Class1();

            Employee e1 = new Employee();
            e1.EmpName = "Van";
            e1.EmpCode = 123;

            Employee e2 = new Employee() { EmpCode = 456, EmpName = "Abc" };

            
        }
    }

    class DemoOverloading
    {
        void Sum (out int kq, int a, int b)
        {
            kq = a + b;
        }
        void Sum(out double kq, double a, double b)
        {
            kq = a + b;
        }
    }

    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public virtual void Display (int c, string n)
        {
            Console.WriteLine($"Name {c} - {n} ");
        }
    }
    class Manager:Employee
    {
        public string EmpAddress { get; set; }
        public override void Display(int c, string n)
        {
            Console.WriteLine($"Name {c} - {n} ");
        }
    }
}
