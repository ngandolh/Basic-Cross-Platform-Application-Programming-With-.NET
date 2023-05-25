using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    class CustomerList
    {
        Customer[] customerList = new Customer[100];
        private VietnameseCustomer vietnameseCust;
        private ForeignerCustomer foreignerCust;
        private int count;
        private float totalForVietnameseCustomer, totalForForeignerCustomer;
        private double averageTotalBill;
        public CustomerList()
        {
            count = 0;
            totalForVietnameseCustomer = 0;
            totalForForeignerCustomer = 0;
            averageTotalBill = 0;
            for (int i = 0; i < 99; i++)
                customerList[i] = new Customer();
        }
        public void InputCustomerList(byte check)
        {
            if (count > 100)
                Console.WriteLine("Error!");
            else
            {
                if (check == 1)
                {
                    customerList[count] = new VietnameseCustomer();
                    vietnameseCust = new VietnameseCustomer();

                    vietnameseCust.InputVietnamese();
                    totalForVietnameseCustomer += vietnameseCust.Quantity;

                    customerList[count] = vietnameseCust;
                    
                    count++;
                }
                else
                {
                    customerList[count] = new ForeignerCustomer();

                    foreignerCust = new ForeignerCustomer();
                    foreignerCust.InputForeigner();
                    totalForForeignerCustomer += foreignerCust.Quantity;

                    customerList[count] = foreignerCust;
                    count++;
                }
            }
        }
        public void CalculateTotalAmountOfConsumption()
        {
            Console.WriteLine("Total amount of consumption (Vietnamese customers): " + totalForVietnameseCustomer);
            Console.WriteLine("Total amount of consumption (Foreigner customers): " + totalForForeignerCustomer);
            Console.ReadKey();
        }

        public void CalculateTheAverageOfForeigner()
        {
            Console.WriteLine("The average of total bill for Foreigner Customer: {0}", (averageTotalBill / totalForForeignerCustomer));
            Console.ReadKey();
        }
        public void DisplayCustomerList()
        {
            if (count == 0)
                Console.WriteLine("No input data!");
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Transaction number {0}", i + 1);
                    if (customerList[i].GetType() == typeof(VietnameseCustomer))
                    {
                        vietnameseCust = (VietnameseCustomer)(customerList[i]);
                        vietnameseCust.DispalyVietnamese();
                    }
                    else
                    {
                        foreignerCust = (ForeignerCustomer)(customerList[i]);
                        foreignerCust.DispalyForeigner();
                    }
                    Console.WriteLine("****************************************");
                }
                Console.ReadKey();
            }
        }
    }
}
