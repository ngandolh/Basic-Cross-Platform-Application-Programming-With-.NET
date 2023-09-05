using System;

namespace DelegateDemo
{
    class AnonymousMethod
    {
        public delegate void MyDelegate(int value);
        static void Main(string[] args)
        {
            MyDelegate printValue = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0} ", val);
            };

            printValue += delegate
            {
                Console.WriteLine("This is Anonymous method!");
            };
            printValue(100);
        }
    }
}
