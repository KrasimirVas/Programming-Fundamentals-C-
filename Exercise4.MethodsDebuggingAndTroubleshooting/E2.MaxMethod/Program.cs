using System;

namespace E2.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            PrintMaxNumber(number1,number2,number3);
        }

        static void PrintMaxNumber(int number1, int number2, int number3)
        {
            int MaxValue = 0;
            if (number1>number2 && number1>number3)
            {
                MaxValue = number1;
            }
            else if (number2>number1 && number2>number3)
            {
                MaxValue = number2;
            }
            else
            {
                MaxValue = number3;
            }
            Console.WriteLine(MaxValue);
        }
    }
}
