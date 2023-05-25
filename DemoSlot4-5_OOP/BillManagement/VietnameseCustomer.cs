using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    class VietnameseCustomer:Customer
    {
        public string CustomerType { get; set; }
        public float Quota { get; set; }
        public double TotalBill { get; set; }

        public VietnameseCustomer()
        {
        }

        public VietnameseCustomer(int customerID, string customerName, string customerAddress, float quantity, float price, string type, float quota) : 
            base(customerID, customerName, customerAddress, quantity, price)
        {
            CustomerType = type;
            Quota = quota;
        }

        public void InputVietnamese()
        {
            base.InputData();
            Console.Write("Customer Type (Living | Business): ");
            this.CustomerType = Console.ReadLine();
            Console.Write("Quota: ");
            this.Quota = float.Parse(Console.ReadLine());

            if (Quantity <= Quota)
                this.TotalBill = Quantity * Price;
            else
                this.TotalBill = Quantity * Price * Quota + (Quantity - Quota)*Price * 2.5;
        }

        public void DispalyVietnamese()
        {
            Console.WriteLine("Customer ID: " + CustomerID);
            Console.WriteLine("Customer Name:  " + CustomerName);
            Console.WriteLine("Address: " + CustomerAddress);
            Console.WriteLine("Customer Type: " + CustomerType);
            Console.WriteLine("Amount of cunsumption: " + Quantity);
            Console.WriteLine("Quota: " + Quota);
            Console.WriteLine("Unit price: " + Price);
            Console.WriteLine("Bill Total: " + TotalBill);
        }


    }
}
