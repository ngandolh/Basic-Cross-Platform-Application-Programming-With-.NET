using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        // Xử lý Singleton bổ sung
        public static List<Product> GetProducts()
        {
            List<Product> listProducts = new List<Product>();
            try
            {
                using (var context = new MyStoreContext())
                {
                    listProducts = context.Products.Include(f => f.Category).ToList();
                }
            }
            catch(Exception ex)
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
                        .SingleOrDefault(m=>m.ProductId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public static void SaveProduct(Product product)
        {
            try
            {
                using(var context = new MyStoreContext())
                {
                    context.Products.Add(product); // Thêm DbSet<Product>
                    context.SaveChanges(); // Cập nhập DB
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteProduct(Product product)
        {
            try
            {
                using (var context = new MyStoreContext())
                {
                    var p1 = context.Products.SingleOrDefault(m=> m.ProductId == product.ProductId);
                    context.Products.Remove(p1); // remove ra khỏi Collection(DbSet)
                    context.SaveChanges(); // Cập nhập database
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateProduct(Product product)
        {
            try
            {
                using (var context = new MyStoreContext())
                {
                    context.Entry<Product>(product).State = EntityState.Modified; //gán trạng  thái
                    context.SaveChanges(); // cập nhập Database
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
