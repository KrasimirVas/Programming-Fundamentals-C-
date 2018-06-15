using System;

namespace P7._CakeIngredients2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredients = Console.ReadLine();
            int counter = 0;
            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                counter++;
                ingredients = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
