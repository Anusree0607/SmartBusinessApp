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

        [HttpPost]
        public IActionResult SaveBranch([FromBody] Branch branch)
        {
            branch.Id = Branches.Count + 1;
            Branches.Add(branch);
            return Ok(branch);
        }
    }
}
