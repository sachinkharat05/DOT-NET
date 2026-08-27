using com.transflower.catalog.entities;
using System.Collections.Generic;

namespace com.transflower.catalog.managers
{
    public class ProductUIManager
    {
        public Product AcceptProductDetails()
        {
            Product product = new Product();

            try
            {
                Console.WriteLine("Enter Product ID:");
                product.SetId(int.Parse(Console.ReadLine()));

                Console.WriteLine("Enter Product Title:");
                product.SetTitle(Console.ReadLine());

                Console.WriteLine("Enter Product Description:");
                product.SetDescription(Console.ReadLine());

                Console.WriteLine("Enter Product Price:");
                product.SetPrice(decimal.Parse(Console.ReadLine()));

                Console.WriteLine("Enter Product Stock:");
                product.SetStock(int.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accepting product details: {ex.Message}");
            }

            return product;
        }

        public void DisplayProductDetails(Product product)
        {
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.WriteLine("\n========== Product Details ==========");
            Console.WriteLine($"ID: {product.GetId()}");
            Console.WriteLine($"Title: {product.GetTitle()}");
            Console.WriteLine($"Description: {product.GetDescription()}");
            Console.WriteLine($"Price: ${product.GetPrice():F2}");
            Console.WriteLine($"Stock: {product.GetStock()}");
            Console.WriteLine($"Likes: {product.GetLikes()}");
            Console.WriteLine("====================================\n");
        }

        public void DisplayAllProducts(List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("\n========== All Products ==========");
            foreach (var product in products)
            {
                DisplayProductDetails(product);
            }
        }
    }
}