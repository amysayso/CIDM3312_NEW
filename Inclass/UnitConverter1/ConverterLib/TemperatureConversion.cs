using System;

namespace ConverterLib
{
    interface ITemperatureConverter
    {
        decimal CelsiusToFahrenheit(decimal TempInCelsius);
    }

    public class MyTemperatureConverter: ITemperatureConverter
    {
        public decimal CelsiusToFahrenheit(decimal TempInCelsius)
        {
            //F = C * (9/5) +32 
            return TempInCelsius * (9m/5m) +32;
        } 
    }

    public class AltnerativeTemperatureConverter: ITemperatureConverter
    {
        public decimal CelsiusToFahrenheit(decimal TempInCelsius)
        {
            //F = C * (1.8) +32 
            return TempInCelsius * (1.8m) +32;
        } 
    }
}
