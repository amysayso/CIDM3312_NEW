using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverterMVC11072018.Models;

namespace UnitConverterMVC11072018.Controllers
{
    public class ConverterController : Controller
    {
        //HW Example
        //ADD
        //https://localhost:5001/Converter/Add?left=3&right=50
       public string Add(decimal left, decimal right)
       {
          
           return $"{left} plus {right} is: {left+right}";
       }


        //HW example 
        //Ceiling
        //https://localhost:5001/Converter/Ceiling?number=34.34
       public string Ceiling(decimal number)
       {
           decimal result = Math.Ceiling(number);
           return $"The ceiling of {number} is {result}";
       }

       
    }
}