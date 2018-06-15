using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace L4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b(?<day>[\d]{2})([.\-\/])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>[\d]{4})\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match m in matches)
            {
                var day = m.Groups["day"].Value;
                var month = m.Groups["month"].Value;
                var year = m.Groups["year"].Value;


                Console.Write($"Day: {day}, ");
                Console.Write($"Month: {month}, ");
                Console.WriteLine($"Year: {year}");
                
            }
            
        }
    }
}
