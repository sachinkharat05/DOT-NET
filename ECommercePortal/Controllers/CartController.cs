using Microsoft.AspNetCore.Mvc;
using ECommercePortal.Models;
using System.Collections.Generic;
using System.Linq;

namespace ECommercePortal.Controllers
{
    public class CartController : Controller
    {
        // Static Shopping Cart
        private static List<CartItem> cart = new List<CartItem>();

        //=========================================
        // Display Shopping Cart
        //=========================================
        public IActionResult Index()
        {
            return View(cart);
        }

        //=========================================
        // Display Add To Cart Page
        //=========================================
        [HttpGet]
        public IActionResult AddToCart(int id)
        {
            // Normally this product comes from database

            Product product = new Product()
            {
                Id = id,
                Name = "Laptop",
                Price = 55000
            };

            return View(product);
        }

        //=========================================
        // Add Product To Cart
        //=========================================
        [HttpPost]
        public IActionResult AddToCart(int id, int quantity)
        {
            CartItem item = cart.FirstOrDefault(c => c.Product.Id == id);

            if (item == null)
            {
                Product product = new Product()
                {
                    Id = id,
                    Name = "Laptop",
                    Price = 55000
                };

                cart.Add(new CartItem()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                item.Quantity += quantity;
            }

            return RedirectToAction("Index");
        }

        //=========================================
        // Remove Item From Cart
        //=========================================
        public IActionResult Remove(int id)
        {
            CartItem item = cart.FirstOrDefault(c => c.Product.Id == id);

            if (item != null)
            {
                cart.Remove(item);
            }

            return RedirectToAction("Index");
        }

        //=========================================
        // Clear Shopping Cart
        //=========================================
        public IActionResult Clear()
        {
            cart.Clear();

            return RedirectToAction("Index");
        }

        //=========================================
        // Checkout
        //=========================================
        public IActionResult Checkout()
        {
            ViewBag.TotalAmount = cart.Sum(c => c.Product.Price * c.Quantity);

            return View();
        }
    }
}