using System;

namespace ConverterLib.Mass
{
    public class PoundsToKilogram
    {
        public string Mass(decimal massIn)
        {
           //Pounds to kilogram
            decimal result = Math.Round((massIn / 2.2046m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} lbs convert to {lResult} kg";

        }

    }
}