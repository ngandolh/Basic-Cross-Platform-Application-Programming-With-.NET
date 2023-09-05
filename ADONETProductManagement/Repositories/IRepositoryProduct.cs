using System.Collections.Generic;
using BusinessObjects;

namespace Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Product p);
        void DeleteProduct(Product p);
        void UpdateProduct(Product p);
        List<Category> GetCategories();
        List<Product> GetProducts();
    }
}
