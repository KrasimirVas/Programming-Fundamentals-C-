using System;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            string toHex = Convert.ToString(number, 16).ToUpper();
            string toBinary = Convert.ToString(number, 2).ToUpper();

            Console.WriteLine(toHex);
            Console.WriteLine(toBinary);
        }
    }
}
