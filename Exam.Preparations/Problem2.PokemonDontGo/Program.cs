using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long sumOfAllRemoved = 0;

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                long currentValue = 0;

                if (index<0)
                {
                    currentValue = numbers[0];
                    sumOfAllRemoved += currentValue;
                    numbers[0] = numbers[numbers.Count - 1];

                }
                else if (index>=numbers.Count)
                {
                    currentValue = numbers[numbers.Count - 1];
                    sumOfAllRemoved += currentValue;
                    numbers[numbers.Count - 1] = numbers[0];

                }
                else
                {
                    currentValue = numbers[index];
                    sumOfAllRemoved += currentValue;
                    numbers.RemoveAt(index);
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i]<=currentValue)
                    {
                        numbers[i] += currentValue;
                    }
                    else
                    {
                        numbers[i] -= currentValue;
                    }

                }


            }
            Console.WriteLine(sumOfAllRemoved);
        }
    }
}
