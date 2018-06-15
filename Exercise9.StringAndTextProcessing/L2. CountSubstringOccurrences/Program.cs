using System;

namespace L2._CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            string search = Console.ReadLine().ToLower();

            int counter = 0;

            int index = text.IndexOf(search);

            while (index!=-1)
            {
                counter++;
                index = text.IndexOf(search, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
