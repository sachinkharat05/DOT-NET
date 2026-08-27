using com.transflower.catalog.services;
using com.transflower.catalog.managers;
using com.transflower.catalog.entities;

namespace com.transflower.catalog.controllers
{
    public class ProductsController
    {
        private ProductService productService;
        private ProductUIManager uiManager;

        public ProductsController(ProductService productService, ProductUIManager uiManager)
        {
            this.productService = productService;
            this.uiManager = uiManager;
        }

        public void ManageInventory(int option)
        {
            switch (option)
            {
                case 1:
                    AddProductToInventory();
                    break;
                case 2:
                    UpdateProductDetails();
                    break;
                case 3:
                    RemoveProductFromInventory();
                    break;
                case 4:
                    ViewProductDetails();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private void AddProductToInventory()
        {
            Console.WriteLine("\n--- Adding a Product to Inventory ---");
            Product product = uiManager.AcceptProductDetails();
            bool success = productService.AddProductToInventory(product);
            if (success)
                Console.WriteLine("Product added successfully!");
            else
                Console.WriteLine("Failed to add product.");
        }

        private void UpdateProductDetails()
        {
            Console.WriteLine("\n--- Updating Product Details ---");
            Console.WriteLine("Enter Product ID to update:");
            int id = int.Parse(Console.ReadLine());
            Product product = productService.GetProduct(id);
            if (product != null)
            {
                uiManager.DisplayProductDetails(product);
                bool success = productService.UpdateProductInventory(product);
                if (success)
                    Console.WriteLine("Product updated successfully!");
            }
            else
                Console.WriteLine("Product not found.");
        }

        private void RemoveProductFromInventory()
        {
            Console.WriteLine("\n--- Removing a Product from Inventory ---");
            Console.WriteLine("Enter Product ID to remove:");
            int id = int.Parse(Console.ReadLine());
            bool success = productService.RemoveProductFromInventory(id);
            if (success)
                Console.WriteLine("Product removed successfully!");
            else
                Console.WriteLine("Product not found.");
        }

        private void ViewProductDetails()
        {
            Console.WriteLine("\n--- View Product Details ---");
            Console.WriteLine("Enter Product ID:");
            int id = int.Parse(Console.ReadLine());
            Product product = productService.GetProduct(id);
            uiManager.DisplayProductDetails(product);
        }
    }
}