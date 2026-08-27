namespace com.transflower.catalog.controllers
{
    public class ProductsController
    {
        public void ManageInventory(int option)
        {
                switch (option)
                {
                    case 1:
                        // Code to add product to inventory
                        Console.WriteLine("Adding product to inventory...");
                        
                        break;
                    case 2:
                        // Code to update product in inventory
                        Console.WriteLine("Updating product in inventory...");
                        break;
                    case 3:
                        // Code to delete product from inventory
                        Console.WriteLine("Deleting product from inventory...");    
                        break;
                    default:
                        // Code for invalid option
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            // Code to manage inventory based on the option selected
        }
         
        public void DisplayProductDetails()
        {
            // Code to display product details

            Console.WriteLine("Product Details:");
            Console.WriteLine("ID: 1");
            Console.WriteLine("Title: Sample Product");
            Console.WriteLine("Description: This is a sample product.");
            Console.WriteLine("Price: $10.00");
            Console.WriteLine("Stock: 100");
            Console.WriteLine("Likes: 50");

        }

    }
}