using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollection
{
    internal class SortedSet
    {
        static void Main1(string[] args)
        {
            //using collection initializer to initialize SortedSet.
            SortedSet<int> mySet = new SortedSet<int>() { 8, 7, 9, 1, 3 };
            //Add the elements in SortedSet using Add method.
            mySet.Add(5);
            mySet.Add(4);
            mySet.Add(6);
            mySet.Add(2);

            Console.WriteLine("Elements of mySet: \n");
            //Accesing elements of SortedSet using foreach loop
            foreach (var val in mySet)
            {
                Console.WriteLine($"{val, 3}");
            }
            Console.ReadLine();

        }
    }
}
