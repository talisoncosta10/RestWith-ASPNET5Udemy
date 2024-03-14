using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstName}/{secondName}")]
        
        public IActionResult Get(string firstName, string secondName)
        {
            if (isNumeric(firstName) && isNumeric(secondName)) 
            { 
                var sum = ConvertToDecimal(firstName) + ConvertToDecimal(secondName);
                return Ok(sum.ToString());
            }
            

            

            return BadRequest("Invalid Input");
        }

        private bool isNumeric(string strName)
        {
            double number;
            bool isNumber = double.TryParse(strName, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }

        private int ConvertToDecimal(string strName)
        {
            throw new NotImplementedException();
        }

        
    }
}
