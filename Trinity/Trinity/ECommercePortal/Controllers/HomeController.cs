using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommercePortal.Models;

namespace ECommercePortal.Controllers;

 

 //Plain MVC Controller
 //each action method  delegates the request to a view for rendering the response
public class HomeController : Controller
{

     public HomeController()
    {
        Console.WriteLine("HomeController Constructor Invoked");
    }
  
  
  
    //Request processing
    //data Access logic
    //Response generation

    public IActionResult Index()
    {

        string title = "Transflower";

        // ViewBag, ViewData, TempData are used to pass data from controller to view
        
        ViewBag.CompanyName = title;
        return View();
    }

    public IActionResult Privacy()
    {

        //Annonymous object to return JSON data
        return Json(new {  
            Message = "This is a sample privacy policy for the Transflower E-Commerce Portal. We value your privacy and are committed to protecting your personal information. This policy outlines how we collect, use, and safeguard your data when you interact with our website and services.",
            DataCollection = "We may collect personal information such as your name, email address, shipping address, and payment details when you make a purchase or create an account. We also collect non-personal information such as browser type, IP address, and browsing behavior to improve our services.",
            DataUsage = "The information we collect is used to process orders, provide customer support, personalize your shopping experience, and send promotional communications. We do not sell or share your personal information with third parties for marketing purposes.",
            DataProtection = "We implement industry-standard security measures to protect your data from unauthorized access, disclosure, alteration, or destruction. Your payment information is processed securely through trusted payment gateways.",
            Cookies = "Our website uses cookies to enhance user experience and analyze site traffic. You can manage your cookie preferences through your browser settings.",
            ThirdPartyLinks = "Our website may contain links to third-party websites. We are not responsible for the privacy practices of these external sites. We encourage you to review their privacy policies before providing any personal information.",
            ChangesToPolicy = "We may update this privacy policy from time to time. Any changes will be posted on this page with an updated effective date. We encourage you to review this policy periodically for any updates."
        });
    }
    public IActionResult Welcome()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
