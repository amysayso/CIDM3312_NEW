using System;

namespace ConverterLib.Mass
{
    public class GramToOunces
    {
        public string Mass(decimal massIn)
        {
           //GramToOUnces
            decimal result = Math.Round((massIn * 0.035274m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} g convert to {lResult} oz";

        }

    }
}