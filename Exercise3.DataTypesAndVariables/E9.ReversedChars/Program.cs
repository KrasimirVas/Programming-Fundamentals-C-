using System;

namespace E9.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());


            Console.Write($"{three}{two}{one}");
        }
    }
}
