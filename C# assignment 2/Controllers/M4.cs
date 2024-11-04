using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C__assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class M4 : ControllerBase
    {
        /// <summary> 
        /// Calculates the atmospheric pressure based on the temperature at which water boils (boilingTemp). 
        /// </summary> 
        /// <returns> 
        /// calculated pressure  and the relative sea level status (-1 for above, 0 for at, or 1 for below sea level). 
        /// </returns> 
        /// <param name="boilingTemp">      (The boiling point of water in degrees Celsius).
        /// </param> 
        /// <example> 
        /// POST : http://localhost:xx/api/M4/BoilingWater
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// Result: boilingTemp = 200
        ///  Output -> 600, -1
        /// </example> 
        /// <example> 
        /// POST : http://localhost:xx/api/M4/BoilingWater
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// Result: boilingTemp = 90
        ///  Output -> 50, 1
        /// </example> 

        [HttpPost("BoilingWater")]
        public string BoilingWater([FromForm] int boilingTemp)
        {
            int pressure = 5 * boilingTemp - 400;
            int seaLevelStatus;

            if (pressure > 100)
            {
                seaLevelStatus = -1;         // Above sea level
            }
            else if (pressure == 100)
            {
                seaLevelStatus = 0;          // At sea level
            }
            else
            {
                seaLevelStatus = 1;          // Below sea level
            }

            return $"{pressure}\n{seaLevelStatus}";
        }

    }
}
