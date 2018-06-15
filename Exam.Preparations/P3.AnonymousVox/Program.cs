using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P3.AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] changes = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            int count = 0;

            string pattern = @"([a-zA-Z]+)(?<placeholder>.+)(\1)";

            var regex = Regex.Matches(text, pattern);
            
            

            foreach (Match match in regex)
            {
                string decodedMessage = match.Groups[1] + changes[count++] + match.Groups[1];
                text = text.Replace(match.Value, decodedMessage);
                
            }
            Console.WriteLine(text);
        }

    }
}
