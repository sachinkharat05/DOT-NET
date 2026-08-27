using com.transflower.catalog.entities;

namespace com.transflower.catalog.managers
{

    //Presentation Layer: This layer will contain classes that handle user interactions and display information. For example, you can have a ProductManager class that accepts product details from user input and displays product information.
    public class ProductUIManager
    {
        
        public Product AcceptProductDetails()
        {
            // Code to accept product details from user input
            Product product = new Product();

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

            return product;
        }
    
        public void DisplayProductDetails(Product product)
        {
            // Code to display product details
            Console.WriteLine("Product Details:");
            Console.WriteLine($"ID: {product.GetId()}");
            Console.WriteLine($"Title: {product.GetTitle()}");
            Console.WriteLine($"Description: {product.GetDescription()}");
            Console.WriteLine($"Price: ${product.GetPrice()}");
            Console.WriteLine($"Stock: {product.GetStock()}");
            Console.WriteLine($"Likes: {product.GetLikes()}");
        }
 }
}