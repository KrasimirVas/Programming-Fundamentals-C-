using System;
using System.Collections.Generic;
using System.Linq;

namespace E3.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.Write("\\u{0:x4}",(int)symbol);
            }
        }
    }
}
