using System;

namespace E6StringAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object concatenatedStrings = word1 + " " + word2;
            string sentence = concatenatedStrings.ToString();
            Console.WriteLine(sentence);
        }
    }
}
