using com.transflower.catalog.entities;


namespace com.transflower.catalog.repositories
{
    public class ProductRepository
    {


        public bool AddProduct(Product product)
        {
            // Code to add product to the repository
            return true; // Return true if added successfully
        }

        public Product GetProductById(int id)
        {
            // Code to retrieve product by id from the repository
            return new Product(); // Return the product if found
        }


        public bool UpdateProduct(Product product)
        {
            // Code to update product in the repository
            return true; // Return true if updated successfully
        }


        public bool DeleteProduct(int id)
        {
            // Code to delete product from the repository
            return true; // Return true if deleted successfully
        }

        //This class will contain methods to perform CRUD operations on Product entities.
        //For example, you can have methods like AddProduct, GetProductById, UpdateProduct, DeleteProduct, etc.
        //You can use a List<Product> to store the products in memory for simplicity.
    }
}
