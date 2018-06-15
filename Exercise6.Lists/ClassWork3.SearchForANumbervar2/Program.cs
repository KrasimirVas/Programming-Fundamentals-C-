using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork3.SearchForANumbervar2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            numbers.Take(commands[1]).

        }
    }
}
