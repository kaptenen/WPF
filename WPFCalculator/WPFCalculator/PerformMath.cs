using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WPFCalculator
{
    public static class PerformMath
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Sub(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
