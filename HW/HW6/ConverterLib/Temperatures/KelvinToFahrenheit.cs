using System;

namespace ConverterLib.Temperatures
{
    public class KelvinToFahrenheit //: ITempConversions
    {
          public string Temp(decimal tempIn)
        {
            //KtoF
            decimal result = Math.Round((tempIn * (9m/5m) - 459.67m ),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} K convert to {strResult} F";
        }
    }
}