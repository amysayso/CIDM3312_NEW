using System;

namespace ConverterLib.Lengths
{
    public class FeetToYards
    {
        public string Lengths(decimal LengthIn)
        {
           //Feet to yard
            decimal result = Math.Round((LengthIn * 0.3333333333m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} F convert to {lResult} Y";

        }

    }
}