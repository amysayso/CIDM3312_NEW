using System;

namespace ConverterLib.Mass
{
    public class GramToKilogram
    {
        public string Mass(decimal massIn)
        {
           //Gram To Kilogram
            decimal result = Math.Round((massIn * 1000m),2);
            string lResult = Convert.ToString(result);
            return $"{massIn} g convert to {lResult} kg";

        }

    }
}