using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(int n)
        {
            if (n < 1)
                throw new ArgumentOutOfRangeException();
            
            long result = 1;
            for (int i = 1; i < n+1; i++)
                result *= (long)i;
            return result;
        }

        public static float Mult(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
