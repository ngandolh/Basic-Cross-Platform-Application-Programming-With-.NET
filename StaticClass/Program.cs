using System;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b; //property
            Console.WriteLine("Please enter a value = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b value = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum = {Calculator.Sum(a, b)}");
            Console.WriteLine($"Sub = {a.Sub(b)}");
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

        }

        public class Employee
        {
            public Employee() { }

        }

        public class Person <T> where T : Employee, Student
        {

        }
    }
}
