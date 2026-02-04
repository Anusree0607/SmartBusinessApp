using Microsoft.AspNetCore.Mvc;
using NetworkServer.Models;

namespace NetworkServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Pen", Price = 10 },
            new Product { Id = 2, Name = "Notebook", Price = 50 }
        };

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(Products);
        }
        [HttpPost]
        public IActionResult SavedProduct([FromBody]Product product)
        {
            product.Id = Products.Count+1;
            Products.Add(product);
            return Ok(product);
        }
    }
}
