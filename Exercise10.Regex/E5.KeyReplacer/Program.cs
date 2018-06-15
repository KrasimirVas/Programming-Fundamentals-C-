using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Za-z]+)([\|<\\])(.*)([\|<\\])([A-Za-z]+)";
            string text1 = Console.ReadLine();
            
            Match startEnd = Regex.Match(text1, pattern);
            string start = startEnd.Groups[1].Value;
            string end = startEnd.Groups[5].Value;

            string input2 = Console.ReadLine();
            string pattern2 = $@"({start})(.*?)({end})";
            MatchCollection result = Regex.Matches(input2, pattern2);

            if (result.Count>0)
            {
                foreach (Match my in result)
                {
                    Console.Write(my.Groups[2].Value);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty result");
            }

           
            
        }
    }
}
