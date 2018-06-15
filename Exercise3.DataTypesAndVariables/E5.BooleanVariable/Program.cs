using System;

namespace E5.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word=="True")
            {
                Console.WriteLine("Yes");
            }
            else if (word=="False")
            {
                Console.WriteLine("No");
            }
        }
    }
}
