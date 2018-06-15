using System;
using System.Collections.Generic;
using System.Linq;

namespace A2.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 1;
            int counterMax = 0;
            int position = 0;
            int positionMax = 0;
            int round = 0;
            int roundmax = 0;


            List<int> result = new List<int>();
            int sum = 0;

            while (input != "Clone them!")
            {
                round++;
                List<int> currentNumbers = input.Split('!').Select(int.Parse).ToList();

                for (int i = 0; i < currentNumbers.Count - 1; i++)
                {
                    if (currentNumbers[i] == currentNumbers[i + 1])
                    {
                        counter++;

                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        position = i;
                        result = currentNumbers;
                        roundmax = round;


                    }
                    else if (counter == counterMax)
                    {
                        if (position == i && result.Sum() < currentNumbers.Sum())
                        {

                            position = i;
                            result = currentNumbers;
                            roundmax = round;
                        }


                    }

                }


                input = Console.ReadLine();

            }
            for (int i = 0; i < result.Count; i++)
            {
                sum += result[i];
            }

            Console.WriteLine($"Best DNA sample {roundmax} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", result));


        }
    }
}
