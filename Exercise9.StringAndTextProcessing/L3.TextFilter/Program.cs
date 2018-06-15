using System;
using System.Collections.Generic;
using System.Linq;


namespace L3.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string text = Console.ReadLine();

            foreach (var word in banWords)
            {
                text=text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
