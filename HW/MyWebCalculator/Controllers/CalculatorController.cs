using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;
using MathLibrary;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        //https://localhost:5001/Calculator/Subtract?left=3&right=2 

        //ADD

        public IActionResult Add(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["AddResult"] = $"{left} + {right} is {MyMathRoutines.Add(left, right)}";
            return View();
        }
    //    public string Add(decimal left, decimal right)
    //     {
    //         return $"{left} + {right} is: {MathLibrary.MyMathRoutines.Add(left, right)}";
    //     }

        //SUBTRACT

        public IActionResult Subtract(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["SubtractResult"] = $"{left} - {right} is {MyMathRoutines.Subtract(left, right)}";
            return View();
        }
        // public string Subtract(decimal left, decimal right)
        // {
        //     return $"{left} - {right} is: {MathLibrary.MyMathRoutines.Subtract(left, right)}";
        // }

        //MULTIPLY
        public IActionResult Multiply(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["MultiplyResult"] = $"{left} * {right} is {MyMathRoutines.Multiply(left, right)}";
            return View();
        }

        // public string Multiply(decimal left, decimal right)
        // {
        //     return $"{left} * {right} is: {MathLibrary.MyMathRoutines.Multiply(left, right)}";
        // }

        //DIVIDE

        public IActionResult Divide(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["DivideResult"] = $"{left} / {right} is {MyMathRoutines.Divide(left, right)}";
            return View();
        }
        // public string Divide(decimal left, decimal right)
        // {
        //     return $"{left} / {right} is: {MathLibrary.MyMathRoutines.Divide(left, right)}";
        // }

        //POWER
        public IActionResult Power(double left, double right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["PowerResult"] = $"{left} ^ {right} is {MyMathRoutines.Power(left, right)}";
            return View();
        }
        // public string Power(double left, double right)
        // {
        //     return $"The power of {left} is {MathLibrary.MyMathRoutines.Power(left,right)}";
        // }

        //CEILING
        public IActionResult Ceiling(decimal number)
        {
            ViewData["number"] = number;
            ViewData["CeilingResult"] = $"{number} is {MyMathRoutines.Ceiling(number)}";
            return View();
        }
        // public string Ceiling(decimal number)
        // {
        //     return $"The ceiling of {number} is {MathLibrary.MyMathRoutines.Ceiling(number)}";
        // }

        //FLOOR
         public IActionResult Floor(decimal number)
        {
            ViewData["number"] = number;
            ViewData["FloorResult"] = $"{number} is {MyMathRoutines.Floor(number)}";
            return View();
        }
        // public string Floor(decimal number)
        // {
        //     return $"The Floor of {number} is {MathLibrary.MyMathRoutines.Floor(number)}";
        // }
    }
}
