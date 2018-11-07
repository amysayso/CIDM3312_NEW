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
        //ADD
        
        public string Add(decimal left, decimal right)
        {
            return $"{left} + {right} is: {MathLibrary.MyMathRoutines.Add(left, right)}";
        }

        //SUBTRACT
        public string Subtract(decimal left, decimal right)
        {
            return $"{left} - {right} is: {MathLibrary.MyMathRoutines.Subtract(left, right)}";
        }

        //MULTIPLY
        public string Multiply(decimal left, decimal right)
        {
            return $"{left} * {right} is: {MathLibrary.MyMathRoutines.Multiply(left, right)}";
        }

        //DIVIDE
        public string Divide(decimal left, decimal right)
        {
            return $"{left} / {right} is: {MathLibrary.MyMathRoutines.Divide(left, right)}";
        }

        //POWER
        public string Power(double left, double right)
        {
            return $"The power of {left} is {MathLibrary.MyMathRoutines.Power(left,right)}";
        }

        //CEILING
        public string Ceiling(decimal number)
        {
            return $"The ceiling of {number} is {MathLibrary.MyMathRoutines.Ceiling(number)}";
        }

        //FLOOR
        public string Floor(decimal number)
        {
            return $"The Floor of {number} is {MathLibrary.MyMathRoutines.Floor(number)}";
        }
    }
}
