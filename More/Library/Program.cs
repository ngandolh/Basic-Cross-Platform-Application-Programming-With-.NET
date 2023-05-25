using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoArrayList();
            DemoList();
        }

        public static void DemoArrayList()
        {
            ArrayList a1 = new ArrayList();
            a1.Add(2);
            a1.Add(4);
            a1.Add(7);
            //a1[0], a2[0]: object
            //convert to integer
            int sum = (int)a1[0] + (int)a1[2];
            //Console.WriteLine(sum);

            ArrayList s = new ArrayList();
            s.Add(new Student(1, "Tom"));
            s.Add(new Student(2, "Tom"));
            s.Add(new Student(3, "Tom"));
            //s[4]).Display():object
            //must to convert Object -> Student
            //((Student)s[4]).Display();

        }

        public static void DemoList()
        {
            List<int> l = new List<int>();
            l.Add(12);
            //lỗi compile
            //l.Add("dsfsdf");
            l.Add(3);

            int sum = l[0] + l[1];
            Console.WriteLine(sum);

        }
    }
}
