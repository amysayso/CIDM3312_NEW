using System;

namespace HW7.Models
{
    public class ConverterViewModel
    {
        public decimal ValueToConvert { get; set; }
        public string ConversionType { get; set; }

        public string ConvertedValue { get; set; }
    }
}