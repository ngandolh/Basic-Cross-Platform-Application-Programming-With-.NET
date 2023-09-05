using System;
using System.IO;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace Demo
{
     class Program
    {
        static void Main(string[] args)
        {
            ViewProduct();
            Console.ReadLine();
        }
        static void ViewProduct()
        {
            DbProviderFactory fac = SqlClientFactory.Instance;
            using var connection = fac.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine("Connection Fail!");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();

            DbCommand command = fac.CreateCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Products";

            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["ProductID"] + " " + reader["ProductName"]);
            }
        }

        static string GetConnectionString()
        {
            IConfiguration builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var tmp = builder["ConnectionStrings: MyStoreDB"];
            return tmp;
        }
    }
}
