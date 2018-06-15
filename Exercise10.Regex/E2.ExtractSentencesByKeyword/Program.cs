using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text= Console.ReadLine();

            string [] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = $@"\b{word}\b";

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence,pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }

        }
    }
}
