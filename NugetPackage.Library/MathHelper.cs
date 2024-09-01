using System;

namespace NugetPackage.Library
{
    public class MathHelper
    {
        public int Factorial(int a)
        {
            if (a == 0)
                return 1;
            else
                return a * Factorial(a - 1);
        }
    }
}
