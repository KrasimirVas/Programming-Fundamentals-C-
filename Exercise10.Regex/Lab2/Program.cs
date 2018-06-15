using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\+359(\s|\-)2\1[0-9]{3}\1[0-9]{4}\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            var result = new List<string>();

            foreach (Match m in matches)
            {
                result.Add(m.Value);
            }
            Console.Write(string.Join(", ", result));
        }
    }
}
