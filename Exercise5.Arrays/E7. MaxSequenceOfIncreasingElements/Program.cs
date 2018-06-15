using System;
using System.Linq;

namespace E7._MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 0;
            int position = 0;

            for (int i = 0; i <array.Length-1; i++)
            {
                if (array[i]<array[i+1])
                {
                    counter++;
                    if (counter>counterMax)
                    {
                        counterMax = counter;
                        position = i + 1;
                    }
                }
                else
                {
                    counter = 1;

                }
            }
            int[] result = new int[counterMax];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[position - counterMax+1+i];
            }
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
