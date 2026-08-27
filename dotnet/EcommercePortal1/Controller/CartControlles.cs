using Microsoft.AspNetCore.Mvc;
using ECommercePortal.Models;
using System.Collections.Generic;
using System.Linq;

namespace ECommercePortal.Controllers
{
    public class CartController : Controller
    {
        private static List<CartItem> cart = new List<CartItem>();

        public IActionResult Index()
        {
            return View(cart);
        }

        [HttpGet]
        public IActionResult AddToCart(int id)
        {
        
            Product product = new Product()
            {
                Id = id,
                Name = "Laptop",
                Price = 55000
            };

            return View(product);
        }

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

        public IActionResult Remove(int id)
        {
            CartItem item = cart.FirstOrDefault(c => c.Product.Id == id);

            if (item != null)
            {
                cart.Remove(item);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            cart.Clear();

            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            ViewBag.TotalAmount = cart.Sum(c => c.Product.Price * c.Quantity);

            return View();
        }
    }
}