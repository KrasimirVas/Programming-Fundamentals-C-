using System;

namespace E5.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fn=Fn-1 +Fn-2

            long number = int.Parse(Console.ReadLine());

           long fibonacciNumber = GetFibonacciNumber(number);
            Console.WriteLine(fibonacciNumber);
            
        }
        static long GetFibonacciNumber(long number)
        {
            long fibonaccin = 1;
            long fibNumber1 = 0;
            long fibNumber2 = 1;

            if (number == 0 || number == 1)
            {
                fibonaccin = 1;                
                return fibonaccin;
            }
            else
            {
             for (long i = 1 ; i <= number; i++)
            {
                    fibonaccin = fibNumber1 + fibNumber2;
                    fibNumber1 = fibNumber2;
                    fibNumber2 = fibonaccin;
             }
                return fibonaccin;

            }

        }

    }
}
