using System;

namespace ConverterLib.Mass
{
    public class OuncesToPounds
    {
        public string Mass(decimal massIn)
        {
           //Ounces to Pounds
            decimal result = Math.Round((massIn * 0.062500m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} F convert to {lResult} Y";

        }

    }
}