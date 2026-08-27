using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
 using Portal.Models;

namespace Portal.Controllers;

public class HomeController : Controller
{
    //HTTP Webserver: Kesrel Web Server
    //Cetralized Application continously 
    //waiting for incomming requests of type HTTP
    //Events for asp.net web application: (CRUD Actions)
    //HTTP GET Request received  READ  ---R
    //HTTP POST Request received CREATE ---C
    //HTTP PUT Request received  UPDATE ---U
    //HTTP DELETE Request received DELETE --D
    //action method
    public IActionResult Index()
    {
        Product product=new Product{ Title="Laptop", UnitPrice=99};
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
 
}
