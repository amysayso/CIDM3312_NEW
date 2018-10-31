using System;

namespace ConverterLib.Lengths
{
    public class MetersToFeet
    {
        public string Lengths(decimal LengthIn)
        {
            //Meters to Feet
            decimal result = Math.Round((LengthIn/0.3048m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} M converts to {lResult} F";

        }

    }
}