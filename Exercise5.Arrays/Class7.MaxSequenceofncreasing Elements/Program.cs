using System;
using System.Linq;

namespace Class7.MaxSequenceofncreasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 0;
            int number = 0;
            int bestNumberPos = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] - array[i] >= 1)
                {
                    counter++;
                    number = array[i + 1];
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        bestNumberPos = number;

                    }
                }
                else
                {
                    counter = 1;
                }






            }
        }
    }
}
