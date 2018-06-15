using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CountSymbolsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = "Foe Doe";

            var letterCounter = sample.Where(char.IsLetterOrDigit)
                                      .GroupBy(char.ToLower)
                                      .Select(counter => new { Letter = counter.Key, Counter = counter.Count() });

            foreach (var counter in letterCounter.OrderByDescending(x=>x.Counter).ThenBy(x=>x.Letter))
            {
                Console.WriteLine(String.Format("{0} = {1}", counter.Letter, counter.Counter));
            }
        }
    }
}
