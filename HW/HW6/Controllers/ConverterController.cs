using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HW6.Models;
using ConverterLib.Temperatures;
using ConverterLib.Lengths;
using ConverterLib.Mass;

namespace HW6.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult TemperatureConvert(decimal tempIn)
        {
            var cToF = new CelsiusToFahrenheit();
            var fToC = new FahrenheitToCelsius();
            var cToK = new CelsiusToKelvin();
            var KtoC = new KelvinToCelsius();
            var fToK = new FahrenheitToKelvin();
            var kToF = new KelvinToFahrenheit();
            
            ViewData["CToF"] = cToF.Temp(tempIn);
            ViewData["fToC"] = fToC.Temp(tempIn);
            ViewData["cToK"] = cToK.Temp(tempIn);
            ViewData["KtoC"] = KtoC.Temp(tempIn);
            ViewData["fToK"] = fToK.Temp(tempIn);
            ViewData["kToF"] = kToF.Temp(tempIn);

            return View();
        }

        public IActionResult LengthsConvert(decimal lengthIn)
        {
            var mToF = new MetersToFeet();
            var fToM = new FeetToMeters();
            var mtoY = new MetersToYard();
            var ytoM = new YardToMeter();
            var fToY = new FeetToYards();
            var ytoF = new YardToFeet();

            ViewData["mToF"] = mToF.Lengths(lengthIn);
            ViewData["fToM"] = fToM.Lengths(lengthIn);
            ViewData["mtoY"] = mtoY.Lengths(lengthIn);
            ViewData["ytoM"] = ytoM.Lengths(lengthIn);
            ViewData["fToY"] = fToY.Lengths(lengthIn);
            ViewData["yToF"] = ytoF.Lengths(lengthIn);

            return View();

        }

        public IActionResult MassConvert(decimal massIn)
        {
            var gToK = new GramToKilogram();
            var kToG = new KilogramToGram();
            var gToO = new GramToOunces();
            var oToG = new OuncesToGram();
            var gToP = new GramToPound();
            var pToG = new PoundToGram();
            var pToO = new PoundsToOunces();
            var oToP = new OuncesToPounds();
            var kToO = new KilogramToOunce();
            var oToK = new OuncesToKilogram();
            var pTok = new PoundsToKilogram();
            var kToP = new KilogramToPound();

           ViewData["gToK"] = gToK.Mass(massIn);
           ViewData["kToG"] = kToG.Mass(massIn);
           ViewData["gToO"] = gToO.Mass(massIn);
           ViewData["oToG"] = oToG.Mass(massIn);
           ViewData["gToP"] = gToP.Mass(massIn);
           ViewData["pToG"] = pToG.Mass(massIn);
           ViewData["pToO"] = pToO.Mass(massIn);
           ViewData["oToP"] = oToP.Mass(massIn);
           ViewData["kToO"] = kToO.Mass(massIn);
           ViewData["oToK"] = oToK.Mass(massIn);
           ViewData["pTok"] = pTok.Mass(massIn);
           ViewData["KToP"] = kToP.Mass(massIn);



            return View();
    
        }
    }
}
