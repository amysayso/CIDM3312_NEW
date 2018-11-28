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
        // public IActionResult Calculator()
        // {
            
        //     return View();
        // }

        [HttpGet]
        public IActionResult DoCalcuation(MathOperation models)
        {
            return View();
        }


        [HttpPost]
        public IActionResult ShowCalculationResults()
        {
            return View();
        }

       
    }
}
