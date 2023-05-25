using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlot6_CollectionsGenerics
{
    class ListGenericDemo
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "A", LastName = "A", Age=20},
                new Person {FirstName = "B", LastName = "B", Age=20},
                new Person {FirstName = "C", LastName = "C", Age=20}
            };

            Console.WriteLine("Count: {0}", people.Count);
            foreach(Person p in people)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"First name: {FirstName} - Last name {LastName} - {Age}";
        }
    }
}
