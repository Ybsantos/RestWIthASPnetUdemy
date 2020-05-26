using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorController.Controllers {
    [Route("api/[controller]")]

    public class CalculatorController : ControllerBase {


        // GET api/values/5/5
        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber) {

            if (isNumeric(firstNumber) && isNumeric(secondNumber)) {
                var sum = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string Number) {
            decimal decimalValue;

            if (decimal.TryParse(Number, out decimalValue)) {

                return decimalValue;
            }
            return 0;

        }

        private bool isNumeric(string strNumber) {

            double number;

            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);

            return isNumber;
        }
    }
}
