using System;

namespace ConverterLib.Mass
{
    public class KilogramToOunce
    {
        public string Mass(decimal massIn)
        {
           //Kilogram To Ounces
            decimal result = Math.Round((massIn * 35.274m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} kg convert to {lResult} oz";

        }

    }
}