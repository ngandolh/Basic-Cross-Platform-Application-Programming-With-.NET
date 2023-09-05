using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using BusinessObjects;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        SqlConnection connection;
        SqlCommand command;
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            return config["ConnectionStrings:MyStoreDB"];
        }
        public List<Product> GetProducts ()
        {
            var listProducts = new List<Product>();
            try
            {
                connection = new SqlConnection(GetConnectionString());
                string sqlCommand = "SELECT * FROM Products";
                command = new SqlCommand(sqlCommand, connection);  
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection); // Connected Data Access
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Product productTemp = 
                            new Product() { ProductId=reader.GetInt32("ProductID"), 
                                ProductName = reader.GetString("ProductName"),
                                CategoryId = reader.GetInt32("CategoryID"),
                                UnitsInStock = reader.GetInt16("UnitsInStock"), 
                                UnitPrice=reader.GetDecimal("UnitPrice")
                            };
                        listProducts.Add(productTemp);                       
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return listProducts;
        }

        public List<Category> GetCategories()
        {
            var listCategories = new List<Category>();
            try
            {
                connection = new SqlConnection(GetConnectionString());
                string sqlCommand = "SELECT * FROM Categories";
                command = new SqlCommand(sqlCommand, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Category categoryTemp =
                            new Category()
                            {
                                CategoryId = reader.GetInt32("CategoryID"),
                                CategoryName = reader.GetString("CategoryName")
                            };
                        listCategories.Add(categoryTemp);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally { connection.Close(); }
            return listCategories;
        }

        public void SaveProduct(Product p)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("INSERT INTO Products(ProductName, CategoryID, UnitsInStock, UnitPrice) " +
                "values(@ProductName, @CategoryID, @UnitsInStock, @UnitPrice)", connection);

            command.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = p.ProductName;
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = p.CategoryId;
            command.Parameters.Add("@UnitsInStock", SqlDbType.Int).Value = p.UnitsInStock;
            command.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = p.UnitPrice;
            try
            { 
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateProduct(Product p)
        {
            connection = new SqlConnection(GetConnectionString());
            string sql = "UPDATE Products SET ProductName=@ProductName, CategoryID=@CategoryID, " +
                "UnitsInStock=@UnitsInStock, UnitPrice=@UnitPrice WHERE ProductID=@ProductId";

            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ProductName", p.ProductName);
            command.Parameters.AddWithValue("@CategoryID", p.CategoryId);
            command.Parameters.AddWithValue("@UnitsInStock", p.UnitsInStock);
            command.Parameters.AddWithValue("@UnitPrice", p.UnitPrice);
            command.Parameters.AddWithValue("@ProductId", p.ProductId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteProduct(Product p)
        {
            connection = new SqlConnection(GetConnectionString());
            string sql = "DELETE Products WHERE ProductID=@ProductId";

            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ProductId", p.ProductId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
