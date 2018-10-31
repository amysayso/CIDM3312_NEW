using System;

namespace ConverterLib.Mass
{
    public class PoundToGram
    {
        public string Mass(decimal massIn)
        {
           //Pound To gram
            decimal result = Math.Round((massIn / 0.0022046m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} LBS convert to {lResult} g";

        }

    }
}