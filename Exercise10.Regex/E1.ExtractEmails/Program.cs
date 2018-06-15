using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))([a-z0-9]+)([\.\-_]?[a-z]+)*@([a-z0-9]+)([\._-]?[a-z0-9]+)*\.[a-z]+";

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }



        }
    }
}
