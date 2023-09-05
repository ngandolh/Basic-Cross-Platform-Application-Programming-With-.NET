using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;

namespace DemoUsingStoreProcedure
{
    class Program
    {
        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            return config["ConnectionStrings:MyStoreDB"]; //Server=(local);Uid=sa;Pwd=1234567890;Database=MyStore
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int CategoryId = 2;
            var result = CountProductsByCategoryId(CategoryId);
            Console.WriteLine($"Number of products by Category Id {CategoryId}");
            Console.WriteLine($"--> OutputValue {result.OutputValue}");
        }
        static (int OutputValue, int ReturnValue) CountProductsByCategoryId(int CategoryID)
        {
            (int OutputValue, int ReturnValue) result;
            string connectionString = GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            CountProductsUsingOutputValue();
            CountProductsUsingReturnValue();

            void CountProductsUsingOutputValue ()
            {
                command.CommandText = "spCountProductsUsingOutputValue";
                command.Parameters.AddWithValue("@CategoryID", CategoryID);
                command.Parameters.Add("@NumberOfProducts", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                result.OutputValue = (int)command.Parameters["@NumberOfProducts"].Value;
            }
            void CountProductsUsingReturnValue()
            {
                command.CommandText = "spCountProductsUsingReturnValue";
                command.Parameters["@NumberOfProducts"].Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                result.ReturnValue = (int)command.Parameters["@NumberOfProducts"].Value;
            }
            connection.Close();

            return result;
        }
    }
}
