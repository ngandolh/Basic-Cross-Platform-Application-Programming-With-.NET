using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Category> GetCategories() => CategoryDAO.GetCategories();
        

        public List<Product> GetProducts() => ProductDAO.GetProducts();
       
    }
}
