using System;
using System.Collections.Generic;
using System.Linq;

namespace L2.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();

            var count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (count.ContainsKey(word)==false)
                {
                    count[word] = 0;
                }
                count[word]++;
            }
            var result = new List<string>();
            foreach (var pair in count)
            {
                if (pair.Value % 2 !=0)
                {
                    result.Add(pair.Key);
                }
                
            }
            
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
