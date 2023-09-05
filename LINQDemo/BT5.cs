using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace LINQDemo
{
    internal class BT5
    {
        private class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void OrderByEx1()
        {
            Pet[] pets = { new Pet { Name="Barley", Age=8 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=1 } };

            IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age);
            foreach(Pet pet in query)
            {
                Console.WriteLine(pet.Name);
            }
        }
    }
}