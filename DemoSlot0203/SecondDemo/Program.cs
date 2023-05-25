using System;

namespace SecondDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kiểu data type TenBien = value;

            //var tmp = true;
            //var myType = 0.00000000000000000000000000000000000000005;
            //Console.WriteLine(tmp.GetType().Name);
            //Console.WriteLine(myType.GetType().Name);

            //dynamic temp;
            //temp = 5.5;
            //Console.WriteLine($"Data type of temp: {temp.GetType().Name}");//double
            //temp = "que Nguyet";
            //Console.WriteLine($"Data type of temp: {temp.GetType().Name}");//string
            //temp = 5;
            //Console.WriteLine($"Data type of temp: {temp.GetType().Name}");//Int32

            //DateTime t = DateTime.Now;
            //Console.WriteLine(t.ToString());

            //var tmp = Console.ReadLine();
            ////convert string to integer.
            //int i = int.Parse(tmp);

            //double d = double.Parse(tmp);

            int i = 5; int j = 5;
            int k;
            //Console.WriteLine("Result: {0}", sum(i, j));//12
            //Console.WriteLine(i);//5
            //Console.WriteLine(j);//5

            Console.WriteLine("Result: {0}", sum(ref i, ref j));//12
            Console.WriteLine(i);//6
            Console.WriteLine(j);//6

            Console.WriteLine("Result: {0}", sumOut(ref i, ref j, out k));//14
            

        }

        static int sum(ref int a, ref int b)
        {
            a++;
            b++;
            return a + b;
        }

        static int sumOut(ref int a, ref int b, out int c)
        {
            a++;
            b++;
            c = a + b;
            return c;
        }
    }
}
