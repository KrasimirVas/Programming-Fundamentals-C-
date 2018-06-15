using System;

namespace P13._GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >=n ; j--)
                {
                    counter++;
                    if (i+j==magicNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
