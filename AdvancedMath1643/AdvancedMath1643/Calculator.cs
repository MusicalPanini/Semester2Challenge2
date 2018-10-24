using System;

namespace AdvancedMath1643
{
    public class Calculator
    {
        public static int Factorial(int input)
        {
            int num = 1;
            for (int i = input; i > 0 ; i--)
            {
                num *= i;
            }
            return num;
        }
    }
}
