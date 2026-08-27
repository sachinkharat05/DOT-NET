using System;

namespace ECommercePortal.Models
{
    public class CartItem
    {
        // Product in the shopping cart
        public Product Product { get; set; }

        // Number of units selected by the customer
        public int Quantity { get; set; }

        // Price of one unit
        public double UnitPrice
        {
            get
            {
                return Product.Price;
            }
        }

        // Total amount for this cart item
        public double TotalAmount
        {
            get
            {
                return Product.Price * Quantity;
            }
        }

        public override string ToString()
        {
            return $"{Product.Name}  Qty: {Quantity}  Total: ₹{TotalAmount}";
        }
    }
}