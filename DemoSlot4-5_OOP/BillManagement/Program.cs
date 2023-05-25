using System;

namespace BillManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int chooseOption;
            CustomerList ds = new CustomerList();
            do
            {
                Console.Clear();
                Console.WriteLine("1. Input the transaction for Vietnamese Customer");
                Console.WriteLine("2. Input the transaction for Foreigner Customer");
                Console.WriteLine("3. Display transactions");
                Console.WriteLine("4. Count the transaction");
                Console.WriteLine("5. Calculate the average of total bill for Foreigner Customer");

                Console.WriteLine("0. Exit");
                Console.Write("Please choose the function: ");
                chooseOption = Convert.ToInt32(Console.ReadLine());
                switch (chooseOption)
                {
                    case 1:
                        Console.Clear();
                        ds.InputCustomerList(1);
                        break;
                    case 2:
                        Console.Clear();
                        ds.InputCustomerList(2);
                        break;
                    case 3:
                        Console.Clear();
                        ds.DisplayCustomerList();
                        break;
                    case 4:
                        Console.Clear();
                        ds.CalculateTotalAmountOfConsumption();
                        break;
                    case 5:
                        Console.Clear();
                        ds.CalculateTheAverageOfForeigner();
                        break;
                }
            } while (chooseOption != 0);
        }
    }
}
