using Microsoft.AspNetCore.Mvc;

using ECommercePortal.Models;
namespace ECommercePortal.Controllers;

public class AuthController : Controller
{
    
    //action methods:

    //Mwrhod overloading: same method name with different parameters
    //Attribute Routing: [HttpGet], [HttpPost], [Route("path")]
    [HttpGet]
    public IActionResult Login()
    {
        Credential credential = new Credential();
        credential.UserName = "";
        credential.Password = "";

        return View(credential);
    }

    [HttpPost]
    public IActionResult Login(Credential credential)
    {
        if(credential.UserName=="admin" && credential.Password=="transflower")
        {
            return RedirectToAction("Welcome", "Home");
        }
        else
        {
            return View();
        }
    }


    [HttpGet]
    public IActionResult Register()
    {

        Customer customer = new Customer();
        customer.Name = "";
        customer.Email = "";
        customer.Phone = "";
        customer.Id =2;

        return   View(customer);
    }

    [HttpPost]
    public IActionResult Register(Customer customer)
    {
        //Logic to register a new user
        //store it inside json file or database
        Console.WriteLine($"New user registered: {customer.Name}, {customer.Email}, {customer.Phone}");
        return  RedirectToAction("Login");
    }

    public IActionResult ChangePassword()
    {
        return View();
    }
}