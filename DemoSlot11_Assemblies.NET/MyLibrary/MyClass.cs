using System;

namespace MyLibrary
{
    public static class MyClass
    {
        public static int Add(this int a, int b) => (a + b);
        public static int Subtract(this int a, int b) => (a - b);
    }
}
