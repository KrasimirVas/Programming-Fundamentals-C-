using System;
using System.Collections.Generic;
using System.Linq;

namespace E6.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int counter = 1;
            int counterMax = 0;
            int position = 0;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                if (counter>counterMax)
                {
                    counterMax = counter;
                    position = numbers[i];
                }
                counter = 1;
            }
            for (int i = 0; i < counter; i++)
            {
                position++;
            }
            Console.WriteLine(position + " ");


        }
    }
}
