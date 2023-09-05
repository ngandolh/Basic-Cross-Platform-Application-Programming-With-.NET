using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            List<Product> listProducts = new List<Product>();

            try
            {
                using (var context = new MyStoreContext())
                {
                    listProducts = context.Products.Include(f => f.Category).ToList();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listProducts;
        }

        public static Product GetProductById(int id) 
        {
            Product product = new Product();
            try
            {
                using (var context = new MyStoreContext())
                {
                    product = context.Products.Include(f => f.Category)
                        .SingleOrDefault(m => m.ProductId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public static void SaveProduct(Product product) { }

        public static void DeleteProduct(int id) { }

        public static void UpdateProduct(Product product) { }
    }
}
