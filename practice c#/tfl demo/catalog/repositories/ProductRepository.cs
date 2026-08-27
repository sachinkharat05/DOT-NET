using com.transflower.catalog.entities;
using System.Collections.Generic;
using System.Linq;

namespace com.transflower.catalog.repositories
{
    public class ProductRepository
    {
        private List<Product> products = new List<Product>();

        public bool AddProduct(Product product)
        {
            if (product != null)
            {
                products.Add(product);
                return true;
            }
            return false;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.GetId() == id);
        }

        public List<Product> GetAllProducts()
        {
            return new List<Product>(products);
        }

        public bool UpdateProduct(Product product)
        {
            var existingProduct = GetProductById(product.GetId());
            if (existingProduct != null)
            {
                existingProduct.SetTitle(product.GetTitle());
                existingProduct.SetDescription(product.GetDescription());
                existingProduct.SetPrice(product.GetPrice());
                existingProduct.SetStock(product.GetStock());
                return true;
            }
            return false;
        }

        public bool DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }
    }
}
