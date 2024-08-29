namespace NugetPackage.Library
{
    public class MathHelper
    {
        public int Add(int a, int b) => a + b;
        public int AddBy2(int a, int b) => a + b + 2;
        public int AddBy4(int a, int b) => a + b + 3;

        public int Factorial(int a)
        {
            if (a == 0)
                return 1;
            else
                return a * Factorial(a - 1);
        }
    }
}
