using System;
using System.Numerics;

namespace E13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(n));
        }
        static BigInteger GetFactorial(BigInteger n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;

        }
    }
}
