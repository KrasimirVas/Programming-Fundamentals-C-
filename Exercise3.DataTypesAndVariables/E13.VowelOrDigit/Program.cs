using System;

namespace E13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

            if (a == 'a' || a == 'e' || a == 'o' || a == 'u' || a == 'i'|| a=='y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(a))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
