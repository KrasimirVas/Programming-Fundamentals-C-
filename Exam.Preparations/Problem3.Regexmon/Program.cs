using System;
using System.Text.RegularExpressions;

namespace Problem3.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patternDidi = @"[^A-Za-z-]+";
            string patternBojo = @"[A-Za-z]+-[A-Za-z]+";

            Regex regexDidi = new Regex(patternDidi);
            Regex regexBojo = new Regex(patternBojo);

            while (true)
            {
                Match didiMatch = regexDidi.Match(input);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value.ToString());
                }
                else
                {
                    return;
                }
                int firstMatchDidi = didiMatch.Index;
                input = input.Substring(firstMatchDidi + didiMatch.Length);

                Match bojoMatch = regexBojo.Match(input);
                if (bojoMatch.Success)
                {

                    Console.WriteLine(bojoMatch.Value.ToString());
                }
                else
                {
                    return;
                }
                int firsyMatchBojo = bojoMatch.Index;
                input = input.Substring(firsyMatchBojo + bojoMatch.Length);
            }
        }
    }
}
