using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
 using Portal.Models;

namespace Portal.Controllers;

public class CustomersController : Controller
{
    //action methods

    public IActionResult Index()
    {
        return View();

    }

    public IActionResult Details()
    {
        return View();

    }

    public IActionResult Insert()
    {
        return View();
    }
}