using System;
using System.Collections.Generic;

namespace DemoCollection
{
    //internal class program
    //{
    //    static void main(string[] args)
    //    {
    //        ilist<student> list = new list<student>();
    //        list.add(new student() { id = 5, name = "tom" });
    //        list.add(new student() { id = 6, name = "thomas" });
    //        list.add(new student() { id = 7, name = "do" });


    //        //foreach(var s in list)
    //        //{
    //        //    console.writeline(s);
    //        //}
    //    }
    //}

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public override string ToString()
        {
            return Id + " - " + Name;
        }
    }
}
