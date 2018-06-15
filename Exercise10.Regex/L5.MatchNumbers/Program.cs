using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace L5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match m in matches)
            {
                Console.Write(m.Value+" ");
            }
        }
    }
}
