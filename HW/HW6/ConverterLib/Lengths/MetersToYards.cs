using System;

namespace ConverterLib.Lengths
{
    public class MetersToYard
    {
        public string Lengths(decimal LengthIn)
        {
             //Meters to yard 
            decimal result = Math.Round((LengthIn * 1.0936132983m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn}M converts to {lResult} Y";

        }

    }
}