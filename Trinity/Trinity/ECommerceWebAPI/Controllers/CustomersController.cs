using Microsoft.AspNetCore.Mvc;

using ECommerceWebAPI.Models;
namespace ECommerceWebAPI.Controllers;



[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
 

    public CustomersController( )
    {
       
    }

    //Each action method in the  API Controller is responsible for 
    // handling a specific HTTP request and
    // returning an appropriate response.
    public IEnumerable<Customer> Get()
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new Customer { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
        };

        return customers;
    }
}
