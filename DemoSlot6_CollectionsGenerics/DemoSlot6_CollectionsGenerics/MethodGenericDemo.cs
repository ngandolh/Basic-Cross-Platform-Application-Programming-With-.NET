using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlot7_CollectionsGenerics
{
    class MethodGenericDemo
    {
        private static void Swap<T>(ref T a, ref T b)
        {
            var temp = b;
            b = a;
            a = temp;
        }
        private static void Main(string[] args)
        {
            // Swap integer value
            int a = 1, b = 2;
            Console.WriteLine($"Data type = {a.GetType()}");
            Console.WriteLine($"Before: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After swapping: a = {a}, b = {b}");

            // Swap boolean value
            bool a1 = true, b1 = false;
            Console.WriteLine($"Data type = {a1.GetType()}");
            Console.WriteLine($"Before: a = {a1}, b = {b1}");
            Swap(ref a1, ref b1);
            Console.WriteLine($"After swapping: a = {a1}, b = {b1}");
            Console.ReadKey();
        }
    }
}

