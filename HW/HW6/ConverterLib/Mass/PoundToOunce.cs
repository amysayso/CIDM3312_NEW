using System;

namespace ConverterLib.Mass
{
    public class PoundsToOunces
    {
        public string Mass(decimal massIn)
        {
           //Ounces to Pounds
            decimal result = Math.Round((massIn * 16),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} oz convert to {lResult} lbs";

        }

    }
}