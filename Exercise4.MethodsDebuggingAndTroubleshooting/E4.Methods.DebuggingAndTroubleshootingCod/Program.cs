using System;

namespace E4.Methods.DebuggingAndTroubleshootingCod
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintName(name);
        



        }
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
