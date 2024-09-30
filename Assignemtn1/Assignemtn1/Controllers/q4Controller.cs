using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignemtn1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        [HttpPost(template:"knockknock")]
        public string Knockknock()
        {
            return "Who's there";           }
    }
}
