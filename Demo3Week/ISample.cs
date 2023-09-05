using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Week
{
    public interface ISample
    {
        static void print()
        {
            Console.WriteLine("Welcome to .NET");
        }
        string GetString(string s)
        {
            return "Hello" + s;
        }
        void Display();
    }

    public class MySample : ISample
    {
        public void Display()
        {
            Console.WriteLine("Hi!");
        }
    }

    public class MySample : ISample
    {
        public void Display()
        {
            Console.WriteLine("Hi!");
        }

    }
}
