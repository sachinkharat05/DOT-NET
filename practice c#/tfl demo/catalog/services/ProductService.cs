
using com.transflower.catalog.entities;
namespace com.transflower.catalog.services
{
    public class ProductService
    {
        public decimal CalculateDiscountedPrice(decimal price, decimal discountPercentage)
        {
            // Code to calculate discounted price
            return price - (price * discountPercentage / 100);
        }
        public bool CheckStockAvailability(int stock, int requiredQuantity)
        {
            // Code to check stock availability
            return stock >= requiredQuantity;
        }

        public void LikeProduct(Product product)
        {
            // Code to like a product
            int currentLikes = product.GetLikes();
            product.SetLikes(currentLikes + 1);
        }

        //This class will contain business logic related to products.
        //For example, you can have methods like CalculateDiscountedPrice, CheckStockAvailability, etc.
    }
}
