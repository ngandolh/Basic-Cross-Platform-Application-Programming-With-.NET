using System;

namespace Slot_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Library.Employee e = new Library.Employee();
            e.name = "Tom";
            //Không gọi dc address trong Employee do scope internal.
            
        }
    }
}
