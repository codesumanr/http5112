using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C__assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class M2 : ControllerBase
    {
        /// <summary>
        /// Calculates the remaining cupcakes after distributing them to a students in class.
        /// </summary>
        /// <param name="largeCupcakes">The number of large boxes of cupcakes.
        /// (Each large capcakes box contains 8 cupcakes).
        /// </param>
        /// <param name="smallCupcakes">The number of small boxes of cupcakes .
        /// (Each small capcakes box contains 3 cupcakes).
        /// </param>
        /// <returns>
        /// The number of remaining cupcakes after 28 cupcakes are distributed.
        /// </returns>
        /// <example>
        /// POST :http://localhost:xx/api/M2/Cupcakes_Party
        /// Headers:  content-type: application/json; charset=utf-8
        /// Body: largeCupcakes=5   & smallCupcakes=5
        /// Output: 27
        ///
        ///  POST :http://localhost:xx/api/M2/Cupcakes_Party
        /// Headers: content-type: application/json; charset=utf-8
        /// Body: largeCupcakes=7 &smallCupcakes=5
        /// Output: 43
        /// </example>
        [HttpPost(template: "Cupcakes_Party")]

        public int Cupcakes([FromForm] int largeCupcakes, [FromForm] int smallCupcakes)
        {
            // Calculate total number of cupcakes based on large and small boxes
            int totalCupcakes = (largeCupcakes * 8) + (smallCupcakes * 3);

            // Define the number of cupcakes to be distributed
            const int cupcakesDistributed = 28;

            // Calculate remaining cupcakes after distribution
            int remainingCupcakes = totalCupcakes - cupcakesDistributed;

            // Number of remaining cupcakes
            return remainingCupcakes;
        }
    }

}

