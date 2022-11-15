using MathApp1.Api.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MathApp1.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InternController : ControllerBase
    {
        [HttpGet("Interns")]
        public IActionResult GetAll()
        {
            MathAppDBContext ctx = new MathAppDBContext();
            var internlist = ctx.Users.ToList();
            if (internlist.Count == 0)
            {
                return NotFound();
            }
            return Ok(internlist);
        }
    }
}
