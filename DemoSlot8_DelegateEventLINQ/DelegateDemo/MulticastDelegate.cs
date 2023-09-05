using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void MyDelegate(string msg);
    class MyClass
    {
        public static void Print(string msg) => Console.WriteLine($"{msg.ToUpper()}");
        public static void Show(string msg) => Console.WriteLine($"{msg.ToLower()}");
        public static void Display(string msg) => Console.WriteLine($"{msg}");

    }
    class MulticastDelegate
    {
        static void Main(string[] args)
        {
            string msg = "Multicast delegate!";

            MyDelegate myDele01 = MyClass.Print;
            MyDelegate myDele02 = MyClass.Show;
            MyDelegate myDele = myDele01 + myDele02;
            Console.WriteLine("----- Combine MyDele01 + MyDele02 -----");
            myDele(msg);

            Console.WriteLine("----- Combine MyDele01 + MyDele02 + MyDele03-----");
            MyDelegate myDele03 = MyClass.Display;
            myDele += myDele03;
            myDele(msg);

            Console.WriteLine("----- Remove MyDele02 -----");
            myDele -= myDele02;
            myDele("Hello!");
        }
    }

}
