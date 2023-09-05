using System;
using MyClassLibrary;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            var kq = c.Sum(10, 5);
            Console.WriteLine($"{kq}");
        }
    }
}
