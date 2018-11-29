using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm2.Models;
using MathLibrary;


namespace Midterm2.Controllers
{
    public class MathController : Controller
    {

        [HttpGet]
        public IActionResult DoCalculation()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperation operation)
        {
            switch(operation.Operator)
            {
                case "+":
                    operation.Result = MathLibrary.MyMathRoutines.Add(operation.LeftOperand, operation.RightOperand);
                    break;
                
                case "-":
                    operation.Result = MathLibrary.MyMathRoutines.Subtract(operation.LeftOperand, operation.RightOperand);
                    break;

                case "*":
                    operation.Result = MathLibrary.MyMathRoutines.Multiply(operation.LeftOperand, operation.RightOperand);
                    break;
                
                case "/":
                    operation.Result = MathLibrary.MyMathRoutines.Divide(operation.LeftOperand, operation.RightOperand);
                    break;
            }
            return View(operation);
        }

       
    }
}
