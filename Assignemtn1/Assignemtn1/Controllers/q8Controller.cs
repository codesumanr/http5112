using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Assignemtn1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        private const double SmallPrice = 25.50;
        private const double LargePrice = 45.50;
        private const double HstRate = 0.13;
        
        /// <param name="small"></param>
        /// <param name="large"></param>
        /// <returns></returns>
        
        [HttpPost(template:"squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string SquashFellows([FromForm] int small, [FromForm] int large)
        {
            double smallTotal=small*SmallPrice;
            double largeTotal=large*LargePrice;
            double subTotal= smallTotal+largeTotal;

            double tax= Math.Round(subTotal * HstRate, 2);
            double Total= subTotal + tax;

         string response = $"{small} Small @ {SmallPrice.ToString("C3", CultureInfo.CurrentCulture)} = {smallTotal.ToString("C3", CultureInfo.CurrentCulture)}; " +
                              $"{large} Large @ {LargePrice.ToString("C3", CultureInfo.CurrentCulture)} = {largeTotal.ToString("C3", CultureInfo.CurrentCulture)}; " +
                              $"Subtotal = {subTotal.ToString("C3", CultureInfo.CurrentCulture)}; " +
                              $"Tax = {tax.ToString("C3", CultureInfo.CurrentCulture)} HST; " +
                              $"Total = {Total.ToString("C3", CultureInfo.CurrentCulture)}";
            return response;


        }
    }
}
