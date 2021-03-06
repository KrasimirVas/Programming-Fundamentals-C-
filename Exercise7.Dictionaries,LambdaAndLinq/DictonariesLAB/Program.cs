﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DictonariesLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var count = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (count.ContainsKey(num) == false)
                {
                    count[num] = 0;
                }
                count[num]++;
            }
            foreach (var num in count.Keys)
            {
                Console.WriteLine($"{num} -> {count[num]}");
            }

        }
    }
}
