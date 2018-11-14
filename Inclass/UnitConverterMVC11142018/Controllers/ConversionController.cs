using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverterMVC11142018.Models;

using ConverterLib;
using ConverterLib.Temperatures;

namespace UnitConverterMVC11142018.Controllers
{
    public class ConversionController: Controller
    {
        public IActionResult Index()
        {
            string message = "This is the message";
            ViewData ["Message"] = message;
            return View();
        }

       
        public IActionResult Converter()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult DoConversion(ConverterViewModel model)
        {
            switch (model.ConversionType)
            {
                case "CtoF": 
                    var cToF = new CelsiusToFahrenheit();
                    model.ConvertedValue = cToF.Temp(model.ValueToConvert);
                    break;

                case "FtoC":
                    var FtoC = new FahrenheitToCelsius();
                    model.ConvertedValue = FtoC.Temp(model.ValueToConvert);
                    break;

                default:
                break;
            }
            //the conversion work happen in here
            //cToF.Temp(tempIn);
            return View(model);
        }


    }
}
