using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    class GenericMethod
    {
        //Generics method with two types T and U
        public void Display<T, U>(T msg, U value)
        {
            Console.WriteLine($"{msg} : {value} ");
        }
        static void Main(string[] args)
        {
            //Creating object of MyClass
            GenericMethod obj = new GenericMethod();
            //Calling Generics method
            obj.Display<string, int>("Integer", 2050);
            obj.Display<double, char>(155.9, 'A');
            obj.Display<float, double>(358.9F, 255.67);
            Console.ReadLine();
        }
    }


}
