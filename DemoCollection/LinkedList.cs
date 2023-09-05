using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollection
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<Student> listStudent = new LinkedList<Student>();

            listStudent.AddLast(new Student(){ Id = 1, Name = "Tom"});
            listStudent.AddLast(new Student() { Id = 2, Name = "Thomas" });
            listStudent.AddLast(new Student() { Id = 3, Name = "Do" });

            LinkedListNode<Student> tmpNode = listStudent.First;
            listStudent.RemoveLast();
            listStudent.Remove(tmpNode);

            Console.WriteLine("List of Student: ");
            foreach (var student in listStudent)
            {
                Console.WriteLine(student);
            }

        }
    }

   
}
