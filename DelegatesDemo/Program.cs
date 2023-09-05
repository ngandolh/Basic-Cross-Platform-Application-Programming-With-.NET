using System;

namespace DelegatesDemo
{
    //#1. Declare a delegate
    public delegate int DelegateCalculator(int a, int b);

    internal class Program
    {
        //Declare a class delegate
        static int SumDelegateParameter(DelegateCalculator c, int a, int b) => c(a, b);
        static void Main(string[] args)
        {
            //DelegateCalculator tmp = new DelegateCalculator(Calculator.Sum);
            //var result = tmp(5, 6);
            //Console.WriteLine(result);

            var resultFunction = SumDelegateParameter(Calculator.Sum, 5, 9);
            Console.WriteLine(resultFunction);
        }
    }
}
