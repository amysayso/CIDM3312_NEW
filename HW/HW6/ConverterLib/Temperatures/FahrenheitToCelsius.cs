using System;

namespace ConverterLib.Temperatures
{
    public class FahrenheitToCelsius
    {
          public string Temp(decimal tempIn)
         {
            //FtoC
            decimal result = Math.Round(((tempIn - 32m) / 9m * 5m), 2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} F Converts to {strResult} C ";
            
        }
    }
}