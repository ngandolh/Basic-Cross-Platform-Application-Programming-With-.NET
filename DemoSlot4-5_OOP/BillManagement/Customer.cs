using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public float Quantity { get; set; } // Amount of consumption
        public float Price { get; set; } // Unit price

        public Customer(int customerID, string customerName, string customerAddress, float quantity, float price)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            Quantity = quantity;
            Price = price;
        }

        public Customer()
        {
            CustomerID = 0;
            CustomerName = "";
            CustomerAddress = "";
            Quantity = 0;
            Price = 0;
        }

        public void InputData()
        {
            Console.Write("Customer ID: ");
            this.CustomerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Customer Name: ");
            this.CustomerName = Console.ReadLine();
            Console.Write("Address: ");
            this.CustomerAddress = Console.ReadLine();
            Console.Write("Quantity : ");
            this.Quantity = float.Parse(Console.ReadLine());
            Console.Write("Price : ");
            this.Price = float.Parse(Console.ReadLine());
        }


    }
}
