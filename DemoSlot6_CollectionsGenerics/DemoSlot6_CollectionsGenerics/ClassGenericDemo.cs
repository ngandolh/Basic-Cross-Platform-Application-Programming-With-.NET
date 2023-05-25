using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlot7_CollectionsGenerics
{
    class ClassGenericDemo
    {
        private static void Main(string[] args)
        {

            var listInt = new List<int>(10);
            for (var i = 0; i < listInt.Count; i++)
                Console.Write($"{listInt.Get(i)}");
            var listChar = new List<char>(10);
            for (var i = 0; i < listChar.Count; i++)
                Console.Write($"{listChar.Get(i)}");

            //var listStudent = new List<Student>(10);
            //for (var i = 0; i < listStudent.Count; i++)
            //{
            //    Console.Write("Id: ");
            //    Console.Write($"{listStudent.Get(i)}");
            //}
                
            Console.ReadKey();
        }
    }

    record Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class List<T>
    {
        private T[] arrayData;
        public int Count => arrayData.Length;
        public List(int size) => arrayData = new T[size];
        public void Set(int index, T value)
        {
            if (index >= 0 && index < arrayData.Length) arrayData[index] = value;
        }
        public T Get(int index)
        {
            if (index >= 0 && index < arrayData.Length) return arrayData[index];
            return default(T);
        }
    }
}

