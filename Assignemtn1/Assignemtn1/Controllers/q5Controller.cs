using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignemtn1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        [HttpPost(template: "secret")]
        [Consumes("application/json")]
        public string Secret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
