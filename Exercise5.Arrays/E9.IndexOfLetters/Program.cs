using System;
using System.Linq;

namespace E9.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] input = Console.ReadLine().ToLower().ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", input[i], (int)(input[i] - 97));
            }
        }
    }
}