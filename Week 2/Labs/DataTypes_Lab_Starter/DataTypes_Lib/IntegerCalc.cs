using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            if (num1 == int.MaxValue && num2 > 0 || num2 == int.MaxValue && num1 > 0)
                throw new OverflowException();
            if (num1 == int.MinValue && num2 < 0 || num2 == int.MinValue && num1 < 0)
                throw new OverflowException();
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            if (num1 == int.MaxValue && num2 < 0 || num2 == int.MaxValue && num1 < 0)
                throw new OverflowException();
            if (num1 == int.MinValue && num2 > 0 || num2 == int.MinValue && num1 > 0)
                throw new OverflowException();
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public static int Modulus(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}
