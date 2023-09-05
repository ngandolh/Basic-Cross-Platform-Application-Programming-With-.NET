using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    //only function check format
    class Validation
    {
        public static int GetInteger(int min, int max, string mess)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap Id: ");
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < min || value > max) throw new OverflowException("Vuot qua pham vi cho phep.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhap sai format. Nhap lai");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("So nhap vao vuot qua pham vi. Nhap lai");
                }
            }
        }

        public static string GetString(int minLenght, int maxLenght, string mess)
        {
            string value;
            while (true)
            {
                Console.WriteLine(mess);
                value = Console.ReadLine().Trim();
                if (value.Length < minLenght || value.Length > maxLenght)
                    return value;
                Console.WriteLine("Do dai xau chua phu hop. Nhap lai");
            }
        }

        public static DateTime GetDateTime(DateTime minDate, DateTime maxDate, string pattern, string message)
        {
            DateTime value;
            while (true)
            {
                try
                {
                    Console.WriteLine(message);
                    value = DateTime.ParseExact(Console.ReadLine(), pattern, null);
                    if (value < minDate || value > maxDate) throw new OverflowException("Vuot qua pham vi cho phep.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhap sai format. Nhap lai");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("So nhap vao vuot qua pham vi. Nhap lai");
                }
            }
        }
    }
}
