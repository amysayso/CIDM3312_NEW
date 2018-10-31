using System;

namespace ConverterLib.Lengths
{
    public class YardToFeet
    {
        public string Lengths(decimal LengthIn)
        {
            //Yard to Feet
            decimal result = Math.Round((LengthIn * 3),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} Y convert to {lResult} F";

        }

    }
}