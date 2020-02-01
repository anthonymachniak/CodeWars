using System;

namespace PlayingWithDigits
{
    class Program
    {
        static long Main(int baseNumber, int exponent)
        {
            double result = 0;

            foreach(var digit in baseNumber.ToString())
            {
                result += Math.Pow(int.Parse(digit.ToString()), exponent);
                exponent++;
            }

            if(result % baseNumber == 0)
            {
                double factor = result / baseNumber;

                //Console.WriteLine((string)(factor + " * " + result + " = " + baseNumber));
                return (int) factor;
            }

            //Console.WriteLine(-1);
            return -1;
        }
    }
}
