using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    class DelegateAsParameter
    {
        static void InvokeDelegate(MyDelegate dele, string msg)=>dele(msg);
        static void Main(string[] args)
        {
            string msg = "Passing Delegate as a parameter";
            InvokeDelegate(MyClass.Print, msg);
            InvokeDelegate(MyClass.Show, msg);
            InvokeDelegate(MyClass.Display, msg);

            Console.ReadLine();
        }
    }
}
