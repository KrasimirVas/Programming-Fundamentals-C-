using System;

namespace E6.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Math.Abs(long.Parse(Console.ReadLine()));
            bool result = PrimeOrNot(n);
            Console.WriteLine(result);
        }

        private static bool PrimeOrNot(long n)
        {
            long sqrtN = (long)Math.Sqrt(n);
            if (n==0 || n==1)
            {
                return false;
            }
            else if (n>2)
            {
                for (long i = 2; i <= sqrtN; i++)
                {
                    if (n % i==0)
                    {
                        return false;
                    }

                                        
                }
            }
            return true;
        }
    }
    }

