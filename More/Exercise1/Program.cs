using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseList list = new CourseList();
            /*list.InputListOfCourse();
            list.DisplayListOfCourse();
            list.SearchByStartDate();
            */
            list.InitData();
            list.DisplayListOfCourse();
            list.Sort();
            list.DisplayListOfCourse();
        }
    }
}
