using System;

namespace E4.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine( Convert.ToInt32(word, 16));


        }
    }
}
