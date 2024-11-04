using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C__assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class M1 : ControllerBase
    {
        /// <summary>
        /// Determine the final score based on the number of packages delivered and the number of collisions .
        /// Gain = 50 points (for every package delivered).
        /// Lose =10 points (for every collision).
        /// Earn Bonus = 500 points(if the number of packages delivered is greater than the number of collisions ).
        /// </summary>
        /// <param name="Totalcollisions">  Total number of collisions
        /// </param>
        /// <param name="totaldeliveries">   Total number of deliveries
        /// </param>
        /// <returns>
        /// Totalscore = Totaldeliveries * 50 - Totalcollisions * 10 + 500 (if Totaldeliveries > Totalcollisions)
        /// </returns>
        /// <example>
        /// POST :http://localhost:xx/api/M1/Delivedroid
        /// Header: content-type: application/json; charset=utf-8
        /// PostDATA:   Totalcollisions= 5 &  Totaldeliveries = 7 Answer 800
        /// </example>
        /// <example>
        /// POST :http://localhost:xx/api/M1//Delivedroid
        /// Header: content-type: application/json; charset=utf-8
        /// PostDATA:   Totalcollisions = 7 &    Totaldeliveries = 5 Answer 180 
        /// <example>
        /// <example>
        /// POST :http://localhost:xx/api/M1//Delivedroid
        /// Header:  content-type: application/json; charset=utf-8
        /// PostDATA:   collisions = 10  & deliveries = 10  -> 400
        /// </example>
        [HttpPost(template: "Delivedroid")]
        public int Delivedroid([FromForm] int Totalcollisions, [FromForm] int totaldeliveries)
        {
            int Totalscore = totaldeliveries * 50 - Totalcollisions * 10;
            if (Totalcollisions < totaldeliveries)
            {
                Totalscore += 500;
            }
            return Totalscore;
        }
    }
}

