using System;

namespace P6.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int counter = 0;
            while (ingredient =="Bake!")
            {
                counter++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();

            }
            
        }
    }
}
