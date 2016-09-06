using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            return (v1 + v2);
        }

        internal static int Subtract(int v1, int v2)
        {
            return (v1 - v2);
        }

        internal static int Sum(int[] numbers)
        {
            int number = 0;

            foreach (int numb in numbers)
            {
                number = number + numb;
            }
            return number;
        }

        internal static int Multiply(int v1, int v2, int v3)
        {
            return (v1 * v2 * v3);
        }

        internal static int Power(int[] Ole)
        {
            return (int) Math.Pow(Ole[0] , Ole[1]);
        }
    }
}