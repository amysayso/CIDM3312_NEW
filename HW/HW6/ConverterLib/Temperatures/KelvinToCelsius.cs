using System;

namespace ConverterLib.Temperatures
{
    public class KelvinToCelsius //: ITempConversions
    {
          public string Temp(decimal tempIn)
        {
             //KtoC
            decimal result = Math.Round((tempIn - 273.15m),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} Kelvins converts to {strResult} C"; 
        }

    }
}