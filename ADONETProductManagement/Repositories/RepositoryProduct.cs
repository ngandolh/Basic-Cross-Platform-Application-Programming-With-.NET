using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO = new ProductDAO();
        public void DeleteProduct(Product p) => productDAO.DeleteProduct(p);
        public void SaveProduct(Product p) => productDAO.SaveProduct(p);
        public void UpdateProduct(Product p) => productDAO.UpdateProduct(p);
        public List<Category> GetCategories() => productDAO.GetCategories();
        public List<Product> GetProducts() => productDAO.GetProducts();
    }
}
