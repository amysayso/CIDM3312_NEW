using System;

namespace ConverterLib.Mass
{
    public class KilogramToGram
    {
        public string Mass(decimal massIn)
        {
           //KilogramToGram
            decimal result = Math.Round((massIn / 1000m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} kg convert to {lResult} g";

        }

    }
}