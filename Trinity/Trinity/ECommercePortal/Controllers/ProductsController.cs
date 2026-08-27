using Microsoft.AspNetCore.Mvc;
using ECommercePortal.Models;
using System.Collections.Generic;
using System.Linq;

namespace ECommercePortal.Controllers
{
    public class ProductsController : Controller
    {
        // In-memory Product Collection
        private static List<Product> products = new List<Product>()
        {
            new Product { Id = 101, Name = "Laptop", Price = 55000 },
            new Product { Id = 102, Name = "Mobile", Price = 25000 },
            new Product { Id = 103, Name = "Keyboard", Price = 1200 },
            new Product { Id = 104, Name = "Mouse", Price = 800 },
            new Product { Id = 105, Name = "Monitor", Price = 9000 }
        };

        //==============================
        // Display All Products
        //==============================
        public IActionResult List()
        {
            return View(products);
        }

        //==============================
        // Display Product Details
        //==============================
        public IActionResult Details(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //==============================
        // Insert Product (GET)
        //==============================
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        //==============================
        // Insert Product (POST)
        //==============================
        [HttpPost]
        public IActionResult Insert(Product product)
        {
            products.Add(product);

            return RedirectToAction("List");
        }

        //==============================
        // Update Product (GET)
        //==============================
        [HttpGet]
        public IActionResult Update(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //==============================
        // Update Product (POST)
        //==============================
        [HttpPost]
        public IActionResult Update(Product product)
        {
            Product existingProduct =products.FirstOrDefault(p => p.Id == product.Id);

            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }

            return RedirectToAction("List");
        }

        //==============================
        // Remove Product (GET)
        //==============================
        [HttpGet]
        public IActionResult Remove(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //==============================
        // Remove Product (POST)
        //==============================
        [HttpPost]
        public IActionResult Remove(Product product)
        {
            Product existingProduct =
                products.FirstOrDefault(p => p.Id == product.Id);

            if (existingProduct != null)
            {
                products.Remove(existingProduct);
            }

            return RedirectToAction("List");
        }
    }
}



//Different ways of transferring data from Controller to View in ASP.NET Core MVC:
// 1. ViewData: A dictionary object that allows you to pass data from the controller to the view using key-value pairs.
// 2. ViewBag: A dynamic object that allows you to pass data from the controller to the view using properties. It is a wrapper around ViewData and provides a more convenient syntax.
// 3. TempData: A dictionary object that allows you to pass data from one request to another. It is useful for passing data between actions or controllers.
// 4. Model: A strongly-typed object that represents the data you want to pass from the controller to the view.
//  It is the most common and recommended way of transferring data in ASP.NET Core MVC.