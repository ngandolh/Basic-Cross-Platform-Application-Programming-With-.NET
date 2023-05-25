using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Calculator
    {
        //public static int Sum(this int x, int y)
        //{
        //    return x + y;
        //}
        public static int Sum(this int x, int y) => (x + y);
        public static int Sub(this int x, int y)
        {
            return x - y;
        }
        public static int Nhan(this int x, int y)
        {
            return x * y;
        }
    }
}
