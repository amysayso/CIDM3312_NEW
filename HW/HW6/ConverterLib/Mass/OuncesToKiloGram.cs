using System;

namespace ConverterLib.Mass
{
    public class OuncesToKilogram
    {
        public string Mass(decimal massIn)
        {
           //Ounces to Kilogram
            decimal result = Math.Round((massIn / 35.274m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} oz convert to {lResult} kg";

        }

    }
}