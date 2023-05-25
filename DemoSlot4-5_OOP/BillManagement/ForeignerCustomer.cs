using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    class ForeignerCustomer: Customer
    {
        public string National { get; set; }
        public double TotalBill { get; set; }

        public ForeignerCustomer()
        {

        }
        public ForeignerCustomer(int customerID, string customerName, string customerAddress, float quantity, float price, string national) :
            base(customerID, customerName, customerAddress, quantity, price)
        {
            National = national;
        }

        public void InputForeigner()
        {
            base.InputData();
            Console.Write("National: ");
            this.National = Console.ReadLine();
            this.TotalBill = Quantity * Price;
        }

        public void DispalyForeigner()
        {
            Console.WriteLine("Customer ID: " + CustomerID);
            Console.WriteLine("Customer Name:  " + CustomerName);
            Console.WriteLine("Address: " + CustomerAddress);
            Console.WriteLine("National: " + National);
            Console.WriteLine("Amount of consumption: " + Quantity);
            Console.WriteLine("Unit price: " + Price);
            Console.WriteLine("Bill Total: " + TotalBill);
        }

    }
}
