using System;
using System.Collections.Generic;
using System.Linq;

namespace L4.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            
            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));
        }
    }
}
