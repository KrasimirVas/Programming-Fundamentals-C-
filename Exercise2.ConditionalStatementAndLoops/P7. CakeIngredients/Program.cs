using System;

namespace P7._CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int ingredientSum = 0;
            while (ingredient !="Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
                ingredientSum++;
            }
            Console.WriteLine($"Preparing cake with {ingredientSum} ingredients.");
        }
    }
}