using System;
using com.transflower.catalog.entities;
using com.transflower.catalog.managers;
using com.transflower.catalog.controllers;
 
 
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ProductUIManager productUIManager = new ProductUIManager();
            Product product = productUIManager.AcceptProductDetails();
            productUIManager.DisplayProductDetails(product);

        }
    }
}