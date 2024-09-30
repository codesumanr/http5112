using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignemtn1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        [HttpGet(template:"welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
