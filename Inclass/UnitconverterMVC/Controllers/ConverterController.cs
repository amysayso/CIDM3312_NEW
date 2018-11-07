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

        //Temp.Conversions 
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

        public string CtoK(decimal tempIn)
        {
            //CtoK
            decimal result = Math.Round((tempIn + 273.15m),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} C converts to {strResult} K ";
        }

        public string KtoC(decimal tempIn)
        {
            //KtoC
            decimal result = Math.Round((tempIn - 273.15m),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} Kelvins converts to {strResult} C"; 
        }

        public string FtoK(decimal tempIn)
        {
            //FtoK
            decimal result = Math.Round((tempIn + 459.67m ) * (5m/9m),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} F converts to {strResult} K";
        }

        public string KtoF(decimal tempIn)
        {
            //KtoF
            decimal result = Math.Round((tempIn * (9m/5m) - 459.67m ),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} K convert to {strResult} F";
        }

        //Lengths
        public string MtoF(decimal LengthsIn)
        {
            //Meters to Feet
            decimal result = Math.Round((LengthsIn/0.3048m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthsIn} M converts to {lResult} F";

        }

        public string FtoM(decimal LengthsIn)
        {
            //feet to meters 
            decimal result = Math.Round((LengthsIn * 3.2808m), 2);
            string lResult = Convert.ToString(result);
            return $"{LengthsIn} F converts to {lResult} M";

        }

        public string MtoY(decimal LengthsIn)
        {
            //Meters to yard 
            decimal result = Math.Round((LengthsIn * 1.0936132983m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthsIn}M converts to {lResult} Y";
        }

        public string YtoM(decimal LengthsIn)
        {
            //yard to meters 
            decimal result = Math.Round((LengthsIn * 0.9144m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthsIn} Y converts to {lResult} M";
        }

        public string FtoY(decimal LengthsIn)
        {
            //Feet to yard
            decimal result = Math.Round((LengthsIn * 0.3333333333m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthsIn} F convert to {lResult} Y";
        }

        public string YtoF(decimal LengthsIn)
        {
            //Yard to Feet
            decimal result = Math.Round((LengthsIn * 3),2);
            string lResult = Convert.ToString(result);
            return $"{LengthsIn} Y convert to {lResult} F";
        }

        //Mass

        
    }

}
