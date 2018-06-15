using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace L3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match m in matches)
            {
                Console.Write(m.Value+ " ");
            }

        }
    }
}
