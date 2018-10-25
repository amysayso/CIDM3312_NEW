using System;
using ConvertLib;

namespace ConvertLib
{
    public class TemperatureConversions
    {
        public static decimal CelsiusToFahrenheit(int TempC)
        {
            return TempC * (9m/5m) + 32;
        }
    }
}
