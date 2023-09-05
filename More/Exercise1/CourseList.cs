using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class CourseList
    {
        List<Course> courses = new List<Course>();

        public CourseList() { }

        public void InputListOfCourse()
        {
            while (true)
            {
                Console.WriteLine("Course (C) ? OnlineCourse(O)? Stop(S)?");
                string type = Console.ReadLine();
                if (type.ToUpper().Equals("S")) break;
                if (type.ToUpper().Equals("T")) break;
                Course c;
                if (type.ToUpper().Equals("C")) c = new Course();
                else c = new OnlineCourse();
                c.Input();
                courses.Add(c);
            }
        }

        //test data
        public void InitData()
        {
            courses.Add(new Course(1, "PRJ", new DateTime(2022, 1, 1)));
            courses.Add(new Course(2, "CSD", new DateTime(2022, 1, 1)));
            courses.Add(new Course(3, "OSG", new DateTime(2022, 1, 1)));
            courses.Add(new Course(4, "DBI", new DateTime(2022, 1, 1)));
        }
        public void DisplayListOfCourse()
        {
            Console.WriteLine("List of Course:");
            foreach (Course c in courses)
            {
                Console.WriteLine(c);
            }
        }

        public void Search(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine("Danh sach cac course tim duoc: ");
            
            foreach (Course c in courses)
            {
                if (c.StartDate >= startDate && c.StartDate <= endDate)
                    Console.WriteLine(c);
            }
        }

        public void SearchByStartDate()
        {
            DateTime startDate = Validation.GetDateTime(new DateTime(2002, 1, 1),
                                                 new DateTime(2022, 12, 31),
                                                 "dd-MM-yyyy", "Nhap nagy bay dau");
            DateTime endDate = Validation.GetDateTime(new DateTime(2002, 1, 1),
                                                new DateTime(2022, 12, 31),
                                                "dd-MM-yyyy", "Nhap nagy ket thuc");
            Search(startDate, endDate);
        }
        
        //sort by A-Z name.
        public void Sort()
        {
            courses.Sort();
        }
    }
}
