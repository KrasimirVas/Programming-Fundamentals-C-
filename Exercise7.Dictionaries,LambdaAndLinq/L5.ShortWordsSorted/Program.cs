using System;
using System.Collections.Generic;
using System.Linq;

namespace L5.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().ToLower()
            .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            List <string> words= new List<string>().ToList();

            foreach (var word in text)
            {
                if (word.Length<5)
                {
                    words.Add(word);
                }
            }
            var result = words.OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ", result));
            

        }
    }
}
