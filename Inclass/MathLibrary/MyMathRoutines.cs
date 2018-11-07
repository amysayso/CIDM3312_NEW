using System;

namespace MathLibrary
{
    public class MyMathRoutines
    {
        public static decimal Add(decimal left, decimal right)
        {
            return left + right;
        }

        public static decimal Ceiling(decimal number)
        {
            return Math.Ceiling(number);
        }

        public static decimal Subtract (decimal left, decimal right)
        {
            return left - right;
        }

        public static decimal Multiply(decimal left, decimal right)
        {
            return left * right;
        }
        public static decimal Divide(decimal left, decimal right)
        {
            return left / right;

        }

        public static double Power(double number, double power)
        {
            return Math.Pow(number, power);
        }

        public static decimal Floor(decimal number)
        {
            return Math.Floor(number);
        }
    }
}
