using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate int FirstDelegate (int a, int b);
    public delegate void SecondDelegate(string s);
    // 1. định nghĩa delegate tên FirstDelegate đại diện
    // cho hàm có prototype có 2 tham số, return int
    class DemoSimple
    {
        static int Sum(int a, int b) => (a + b);
        static int Sub(int a, int b) => (a - b);
        static int Mul(int a, int b) => (a * b);

        static void CallDelegateAsArg(SecondDelegate s, string msg) => s(msg);

        public static void Main ()
        {
            int x = 5, y = 6, kq, kq1;
            // 2. Gán phương thức để delegate đại diện
            FirstDelegate d = new FirstDelegate(Sub);
            FirstDelegate d1 = Sum;

            // 3. Gọi delegate
            kq = d(x, y);
            kq1 = d1.Invoke(x, y);

            Console.WriteLine($"Result = {kq}");


        }
    }
}
