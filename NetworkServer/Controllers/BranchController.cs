using Microsoft.AspNetCore.Mvc;
using NetworkServer.Models;

namespace NetworkServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BranchController : ControllerBase
    {
        private static readonly List<Branch> Branches = new()
        {
            new Branch { Id = 1, Name = "Main Branch", City = "Hyderabad" },
            new Branch { Id = 2, Name = "City Branch", City = "Bangalore" }
        };

        [HttpGet]
        public IActionResult GetAllBranches()
        {
            return Ok(Branches);
        }
    }
}
