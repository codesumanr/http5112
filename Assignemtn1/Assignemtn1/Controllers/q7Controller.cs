using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignemtn1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        [HttpGet(template: "timemachine")]
        public string timeMachien([FromQuery]int days)
        {
            DateTime currentdate = DateTime.Today;
            DateTime adjustDate=currentdate.AddDays(days);
            return adjustDate.ToString("yyyy-MM-dd");
        }
    }
}
