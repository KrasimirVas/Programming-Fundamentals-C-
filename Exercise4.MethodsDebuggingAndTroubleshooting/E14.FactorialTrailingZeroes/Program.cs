using System;
using System.Numerics;

namespace E14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            GetFactorial(n);
            
        }
        static void GetFactorial(BigInteger n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            string factorialStr = factorial.ToString();
            int counter = 0;
            for (int i = 0; i < factorialStr.Length; i++)
            {
                if (factorial%10==0)
                {
                    counter++;
                    factorial /= 10;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
        

                
            }
            

        } 
    

