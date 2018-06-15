using System;

namespace Loops.E3GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int difference = Math.Max(number1, number2) - Math.Min(number1, number2);
            int greatesNumber = 0;

            for (int i = Math.Min(number1,number2); i >=1; i--)
            {
                if (number1 % i==0 && number2 % i==0)
                {
                    greatesNumber = i;
                    Console.WriteLine(greatesNumber);
                    return;
                }
                
            }

        }
    }
}
