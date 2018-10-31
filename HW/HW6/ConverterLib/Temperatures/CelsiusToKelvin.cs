using System;

namespace ConverterLib.Temperatures
{
    public class CelsiusToKelvin //: ITempConversions
    {
          public string Temp(decimal tempIn)
        {
            //CtoK
            decimal result = Math.Round((tempIn + 273.15m),2);
            string strResult = Convert.ToString(result);
            return $"{tempIn} C converts to {strResult} K ";
        }
    }
}