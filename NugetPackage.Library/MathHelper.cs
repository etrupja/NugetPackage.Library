using System;

namespace NugetPackage.Library
{
    public class MathHelper
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public int Divide(int a, int b) => a / b;

        public int Modulus(int a, int b) => a % b;

        public int Power(int a, int b) => (int)Math.Pow(a, b);

        public int Factorial(int a)
        {
            if (a == 0)
                return 1;
            else
                return a * Factorial(a - 1);
        }
    }
}
