using System;

namespace ConverterLib.Lengths
{
    public class FeetToMeters
    {
        public string Lengths(decimal LengthIn)
        {
            //feet to meters 
            decimal result = Math.Round((LengthIn * 3.2808m), 2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} F converts to {lResult} M";

        }

    }
}