using System;

namespace ConverterLib.Temperatures
{
    public class FahrenheitToKelvin
    {
           public string Temp(decimal tempIn)
        {
            //FtoK
            decimal result = Math.Round((tempIn + 459.67m ) * (5m/9m),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} F converts to {strResult} K";
        }
    }
}