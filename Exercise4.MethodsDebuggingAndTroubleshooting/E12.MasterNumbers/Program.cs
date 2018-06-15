using System;

namespace E12.MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigitsDevBy7(i) && HasEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        
        static bool IsPalindrome ( int i)
        {
            int remainder = 0;
            int reverse = 0;
            int temp = i;
            while (i!=0)
            {
                remainder = i % 10;

                reverse = reverse * 10 + remainder;

                i /= 10;
            }
            if (temp==reverse)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static bool HasEvenDigit (int i)
        {
            int current = 0;
            bool hasEven = false;
            while (i!=0)
            {
                current = i % 10;
                if (current%2==0)
                {
                    hasEven = true;
                    return hasEven;
                }
                i /= 10;
            }
            return hasEven;
        }
        static bool SumOfDigitsDevBy7 ( int i)
        {
            int sumOfDigits = 0;
                      
            
                while(i!=0)
            {
                sumOfDigits += i % 10;
                i /= 10;
            }
            if (sumOfDigits % 7==0)
            {                
                return true;
            }
            else
            {
                return false;
            }
        }

    }



}
