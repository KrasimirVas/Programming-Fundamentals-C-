using System;

namespace E15.FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int num = 2; num <= number; num++)
            {
                bool IsTrue = true;
                for (int digit = 2; digit <= Math.Sqrt(num); digit++)
                {
                    if (num % digit == 0)
                    {
                        IsTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {IsTrue}");


            }
        }
    }
}
