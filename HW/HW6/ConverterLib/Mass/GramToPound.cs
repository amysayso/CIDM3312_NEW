using System;

namespace ConverterLib.Mass
{
    public class GramToPound
    {
        public string Mass(decimal massIn)
        {
           //GramToPound
            decimal result = Math.Round((massIn * 0.0022046m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} g convert to {lResult} LBS";

        }

    }
}