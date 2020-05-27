using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorController.Controllers {
    [Route("api/[controller]")]

    public class CalculatorController : ControllerBase {


        // GET api/values/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber) {

            if (isNumeric(firstNumber) && isNumeric(secondNumber)) {
                var sum = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }
        // GET api/values/substraction/5/5
        [HttpGet("substraction/{firstNumber}/{secondNumber}")]
        public IActionResult Substraction(string firstNumber, string secondNumber) {

            if (isNumeric(firstNumber) && isNumeric(secondNumber)) {
                var substraction = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(substraction.ToString());

            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/multiplication/5/5
        [HttpGet("substraction/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber) {

            if (isNumeric(firstNumber) && isNumeric(secondNumber)) {
                var multiplication = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(multiplication.ToString());

            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/division/5/5
        [HttpGet("substraction/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber) {

            if (isNumeric(firstNumber) && isNumeric(secondNumber)) {
                var division = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(division.ToString());

            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/mean/5/5
        [HttpGet("substraction/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber) {

            if (isNumeric(firstNumber) && isNumeric(secondNumber)) {
                var mean = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(mean.ToString());

            }
            return BadRequest("Invalid Input");
        }


        // GET api/values/square-root/5/5
        [HttpGet("square-root/{number}")]
        public IActionResult SquareRoot(string number) {

            if (isNumeric(number)) {
                var squareRoot = Math.Sqrt((double)ConvertToDecimal(number));
                return Ok(squareRoot.ToString());

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
