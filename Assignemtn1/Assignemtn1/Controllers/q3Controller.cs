using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignemtn1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        [HttpGet(template:"cube/{number}")]
        public int Cube(int number)
        {
            int cube=number*number*number;
            return cube;
        }
    }
}
