using System;

namespace ClassLibrary
{
    public class Class1 /// public
    {
        public string Name;
    }

    class Class2  // internal
    {
        public string Address;
    }
    public class Employee
    {
        private string employeeCode; // Field
        public string EmployeeCode  // Property
        {
            get 
            { 
                return employeeCode; 
            }
            set
            {
                employeeCode = value;
            }
        }

        public string EmployeeName { set; get; }
    }
}
