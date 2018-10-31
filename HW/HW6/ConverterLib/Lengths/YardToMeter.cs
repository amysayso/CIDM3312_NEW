using System;

namespace ConverterLib.Lengths
{
    public class YardToMeter
    {
        public string Lengths(decimal LengthIn)
        {
             //yard to meters 
            decimal result = Math.Round((LengthIn * 0.9144m),2);
            string lResult = Convert.ToString(result);
            return $"{LengthIn} Y converts to {lResult} M";

        }

    }
}