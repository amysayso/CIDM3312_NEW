using System;

namespace ConverterLib.Mass
{
    public class KilogramToPound
    {
        public string Mass(decimal massIn)
        {
            //KilogramToPound
            decimal result = Math.Round((massIn * 2.2046m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} kg convert to {lResult} lbs";

        }

    }
}