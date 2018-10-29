using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitconverterMVC.Models;

namespace UnitconverterMVC.Controllers
{
    public class ConverterController : Controller
    {
        public string Index(string type, string unitvalue)
        {
            //CtoF
            double val = Convert.ToDouble(unitvalue);
            val = val * (9/5) + 32;
            return $"{type} and {val}";

        }

        public string FtoC(decimal tempIn)
        {
            //FtoC
            decimal result = Math.Round(((tempIn - 32m) / 9m * 5m), 2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} F Converts to {strResult} C ";
            
        }


    }
}
