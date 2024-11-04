using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C__assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class M5 : ControllerBase
    {
        /// <summary> 
        /// Calculates the  total shifted sum  after applying a specified number of shifts. . 
        /// </summary> 
        /// <returns>
        /// Returns the total shifted sum.
        /// </returns>
        /// <param name="initialValue"> The starting number where the calculate the shifty sum start.
        /// </param> 
        /// <param name="numberOfShifts">The total number of  shift applied.
        /// </param>
        /// <example> 
        /// POST: https://localhost:xx/api/M5/CalculateValue
        /// HEADERS: content-type: application/json; charset=utf-8
        /// REQUEST: initialValue=15  & numberOfShifts =5 
        /// Output -> 1666665
        /// </example> 

        [HttpPost(template: "CalculateValue")]
        public int CalculateValue([FromForm] int initialValue, [FromForm] int numberOfShifts)
        {
            int initialSum = 0;
            int currentValue = initialValue;
            for (int i = 0; i <= numberOfShifts; i++)
            {
                initialSum += currentValue;
                currentValue *= 10;
            }
            return initialSum;
        }

    }
}