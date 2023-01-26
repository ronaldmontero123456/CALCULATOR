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
        public CalculateController()
        {
                
        }

        [HttpPost]
        public IActionResult GetResultOfCalculate(string value)
        {
            try
            {
                DataTable dt = new DataTable();
                var response = dt.Compute(value, "").ToString();

                var result = new WebResponse<double>()
                {
                    Body = double.Parse(response),
                    IsSuccess = true,
                    Message = "Success",
                    StatusCode = "200",
                };

                return Ok(result);
            }
            catch(Exception ex) 
            {
                var result = new WebResponse<double>()
                {
                    Body = 0.00,
                    IsSuccess = false,
                    Message = ex.Message,
                    StatusCode = "",
                };
                return BadRequest(result);
            }
        }
    }
}
