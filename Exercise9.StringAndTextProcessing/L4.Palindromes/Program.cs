using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = Console.ReadLine().Split(new char[] { ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            StringBuilder sb = new StringBuilder().;

            for (int i = words.Length-1; i >= 0; i--)
            {
                sb.Append(words[i]);
            }
            
        }
    }
}
