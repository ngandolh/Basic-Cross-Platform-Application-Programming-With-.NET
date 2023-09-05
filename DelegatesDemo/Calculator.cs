using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class Calculator
    {
        public static int Sum(int x, int y) => x + y;
        public static int Sub(int x, int y) => x - y;
        public static int Mul(int x, int y) => x * y;
        public static float Div(int x, int y) => (float)x / y;
    }
}
