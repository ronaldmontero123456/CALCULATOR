using CALCULATOR.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CALCULATOR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetResultOfCalculate(string value)
        {
            try
            {
                DataTable dt = new DataTable();
                var response = dt.Compute(value, "");

                var result = new WebResponse<double>()
                {
                    Body = (double)response,
                    IsSuccess = true,
                    Message = "Success",
                    StatusCode = "200",
                };

                return Ok(result);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
