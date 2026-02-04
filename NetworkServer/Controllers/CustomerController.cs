using Microsoft.AspNetCore.Mvc;
using NetworkServer.Models;

namespace NetworkServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private static readonly List<Customer> Customers = new()
        {
            new Customer { Id = 1, Name = "Ravi", Mobile = "9876543210" },
            new Customer { Id = 2, Name = "Anu", Mobile = "9123456789" }
        };

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            return Ok(Customers);
        }

        [HttpPost]
        public IActionResult SaveCustomer([FromBody] Customer customer)
        {
            customer.Id = Customers.Count + 1;
            Customers.Add(customer);
            return Ok(customer);
        }
    }
}
