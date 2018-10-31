using System;

namespace ConverterLib.Temperatures
{
    public class CelsiusToFahrenheit
    {
        // public string Temp(decimal tempIn)
        // {
        //     //CtoF
        //     decimal result = Math.Round((tempIn * (9m/5m) + 32),2);
        //     string strResult = Convert.ToString(result);
        //     return $"{tempIn} C converts to {strResult} F ";
        // }

        public string Temp(decimal tempIn)
        {
            //CtoF
            decimal result = Math.Round((tempIn * (9m/5m) + 32),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} C converts to {strResult} F ";
        }
    }
}
