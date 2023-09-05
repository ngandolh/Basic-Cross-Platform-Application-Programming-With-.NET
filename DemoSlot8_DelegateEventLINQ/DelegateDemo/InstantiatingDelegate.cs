using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    // 1. Declare delegate
    public delegate int MyDelegate2Parameters(int a, int b);
    class InstantiatingDelegate
    {
        static int Add(int x, int y) => (x + y);
        static int Substract(int x, int y) => (x - y);
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 30;
            int result;
            // 2. Set target method
            MyDelegate2Parameters myDele1 = new MyDelegate2Parameters(Add);
            // 3. Invoke method
            result = myDele1(n1, n2);
            Console.WriteLine($"{n1} - {n2} = {result}");

            // 4. Set target method
            MyDelegate2Parameters myDele2 = Substract;
            // 5. Invoke method
            result = myDele2.Invoke(n1, n2);
            Console.WriteLine($"{n1} - {n2} = {result}");
        }
    }
}
