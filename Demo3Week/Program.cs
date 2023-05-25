using System;

namespace Demo3Week
{
    class Program
    {
        static void Main(string[] args)
        {

            String str;
            MySample obj = new MySample();
            obj.Display();
            //obj.Print(); //Error
            //Default Implement Method
            ISample.print();
            ISample sample = obj;
            str = sample.GetString("Tom");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
