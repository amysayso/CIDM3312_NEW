using System;

namespace ConverterLib.Mass
{
    public class OuncesToGram
    {
        public string Mass(decimal massIn)
        {
           //Ounces to gram
            decimal result = Math.Round((massIn /0.035274m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} oz convert to {lResult} g";

        }

    }
}