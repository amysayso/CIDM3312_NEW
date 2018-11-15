using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HW7.Models;

using ConverterLib;
using ConverterLib.Temperatures;
using ConverterLib.Lengths;
using ConverterLib.Mass;

namespace HW7.Controllers
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
                //TEMP
                case "CtoF": 
                    var cToF = new CelsiusToFahrenheit();
                    model.ConvertedValue = cToF.Temp(model.ValueToConvert);
                    break;

                case "FtoC":
                    var FtoC = new FahrenheitToCelsius();
                    model.ConvertedValue = FtoC.Temp(model.ValueToConvert);
                    break;

                case "CtoK":
                    var CtoK = new CelsiusToKelvin();
                    model.ConvertedValue = CtoK.Temp(model.ValueToConvert);
                    break;

                case "KtoC":
                    var KtoC = new KelvinToCelsius();
                    model.ConvertedValue = KtoC.Temp(model.ValueToConvert);
                    break;

                case "fToK":
                    var fToK = new FahrenheitToKelvin();
                    model.ConvertedValue = fToK.Temp(model.ValueToConvert);
                    break;

                case "kToF":
                    var kToF = new KelvinToFahrenheit();
                    model.ConvertedValue = kToF.Temp(model.ValueToConvert);
                    break;

                //LENGTH
                case "mToF":
                    var mToF = new MetersToFeet();
                    model.ConvertedValue = mToF.Lengths(model.ValueToConvert);
                    break;

                case "fToM":
                    var fToM = new FeetToMeters();
                    model.ConvertedValue = fToM.Lengths(model.ValueToConvert);
                    break;
                
                case "mtoY":
                    var mtoY = new MetersToYard();
                    model.ConvertedValue = mtoY.Lengths(model.ValueToConvert);
                    break;

                case "ytoM":
                    var ytoM = new YardToMeter();
                    model.ConvertedValue = ytoM.Lengths(model.ValueToConvert);
                    break;

                case "fToY":
                    var fToY = new FeetToYards();
                    model.ConvertedValue = fToY.Lengths(model.ValueToConvert);
                    break;

                case "yToF":
                    var yToF = new YardToFeet();
                    model.ConvertedValue = yToF.Lengths(model.ValueToConvert);
                    break;
                
                //MASS
                case "gToK":
                    var gToK = new GramToKilogram();
                    model.ConvertedValue = gToK.Mass(model.ValueToConvert);
                    break;

                case "kToG":
                    var kToG = new KilogramToGram();
                    model.ConvertedValue = kToG.Mass(model.ValueToConvert);
                    break;
                
                case "gToO":
                    var gToO = new GramToOunces();
                    model.ConvertedValue = gToO.Mass(model.ValueToConvert);
                    break;
                
                case "oToG":
                    var oToG = new OuncesToGram();
                    model.ConvertedValue = oToG.Mass(model.ValueToConvert);
                    break;

                case "gToP":
                    var gToP = new GramToPound();
                    model.ConvertedValue = gToP.Mass(model.ValueToConvert);
                    break;

                case "pToG":
                    var pToG = new PoundToGram();
                    model.ConvertedValue = pToG.Mass(model.ValueToConvert);
                    break;

                case "pToO":
                    var pToO = new PoundsToOunces();
                    model.ConvertedValue = pToO.Mass(model.ValueToConvert);
                    break;

                case "oToP":
                    var oToP = new OuncesToPounds();
                    model.ConvertedValue = oToP.Mass(model.ValueToConvert);
                    break;

                case "kToO":
                    var kToO = new KilogramToOunce();
                    model.ConvertedValue = kToO.Mass(model.ValueToConvert);
                    break;

                case "oToK":
                    var oToK = new OuncesToKilogram();
                    model.ConvertedValue = oToK.Mass(model.ValueToConvert);
                    break;

                case "pToK":
                    var pToK = new PoundsToKilogram();
                    model.ConvertedValue = pToK.Mass(model.ValueToConvert);
                    break;

                case "KToP":
                    var KToP = new KilogramToPound();
                    model.ConvertedValue = KToP.Mass(model.ValueToConvert);
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
