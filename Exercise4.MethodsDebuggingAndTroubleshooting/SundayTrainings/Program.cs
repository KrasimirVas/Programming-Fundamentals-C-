using System;

namespace SundayTrainings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                if (IsPalidrome(i) && SumOfDigitsDevBy7(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        static bool IsPalidrome(int i)
        {
            int remainder = 0;
            int temp = i;
            int sum = 0;

            while (i>0)
            {
                remainder = i % 10;
                
                sum = sum * 10 + remainder;
                i = i / 10;
            }
            if (temp==sum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool SumOfDigitsDevBy7 (int i)
        {
            int sumOfDigits = 0;
            while(i>0)
            {
                sumOfDigits += i % 10;
                i /= 10;
            }
            if (sumOfDigits%7==0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool ContainsEvenDigit(int i)
        {
            int digit = 0;
            bool hasEven = false;
            while (i!=0)
            {
                digit = i % 10;
                if (digit % 2 == 0)
                {
                    hasEven = true;
                    return hasEven;
                }
                i /= 10;
            }
            return hasEven;
        }

    }
}
