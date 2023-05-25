using System;
using System.ComponentModel;

namespace DemoDesignPattern
{
    internal class Singleton
    {
        static void Main(string[] args)
        {
          
        }
        //https: //sourcemaking.com/design_patterns/singleton
        class SingletonDemo
        {
            private static SingletonDemo instance;
            private SingletonDemo() { }
            static SingletonDemo() //static contructor
            {
                instance = new SingletonDemo();
            }
            public static SingletonDemo GetSingleteonDemo => instance; //bên ngoài truy cập
        }

        
    }
}
