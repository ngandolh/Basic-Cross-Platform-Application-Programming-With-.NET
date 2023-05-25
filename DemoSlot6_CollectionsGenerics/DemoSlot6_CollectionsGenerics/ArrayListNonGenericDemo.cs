using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlot6_CollectionsGenerics
{
    class ArrayListNonGenericDemo
    {
        static void Main(string[] args)
        {
            ArrayListEmployee t = new ArrayListEmployee();
            t.Run();
        }
    }
    class Employee
    {
        private int empID;
        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public Employee(int empID, string empName)
        {
            this.empID = empID;
            this.empName = empName;
        }
        public Employee(int empID)
        {
            this.empID = empID;
        }
        public override string ToString()
        {
            return empID.ToString();
        }
        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
    }
    public class ArrayListEmployee
    {
        public void Run()
        {
            ArrayList empArray = new ArrayList();
            ArrayList intArray = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                empArray.Add(new Employee(i + 100));
                intArray.Add(i * 5);
            }

            foreach (int i in intArray)
            {
                Console.Write("{0} ", i.ToString());
            }

            Console.WriteLine("\n");

            foreach (Employee e in empArray)
            {
                Console.Write("{0} ", e.ToString());
            }

            Console.WriteLine("\n");
            Console.WriteLine("empArray.Capacity: {0}",
                empArray.Capacity);
        }

    }
}
