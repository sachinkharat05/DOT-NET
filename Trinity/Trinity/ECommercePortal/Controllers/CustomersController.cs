using Microsoft.AspNetCore.Mvc;
using ECommercePortal.Models;

namespace ECommercePortal.Controllers;

public class CustomersController : Controller
{
    public IActionResult Index()
    {

        ViewBag.companyName = "Trinity E-Commerce Portal";
        return View();
    }

    public IActionResult Aboutus()
    {
        string content = "Doing ordinary things extraordinarily well is the key to success.";
        ViewData["Message"] = content;
        return View();
    }

    public IActionResult ContactUs()
    {
        Address address = new Address
        {
            Street = "601, Pune Satar Road",
            City = "Pune",
            State = "MH",
            ZipCode = "41009"
        };
        ViewData["Address"] = address;

        return View();
    }

     public IActionResult Dashboard()
    {
        return View();   //dashboard.cshtml
        
    }

    public IActionResult Profile()
    {
        return View();   //profile.cshtml
    }
  
}