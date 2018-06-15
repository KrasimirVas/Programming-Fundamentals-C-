using System;

namespace P8.CaloriesCounter2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double calories = 0;           
            

            for (int i = 0; i < number; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                switch (ingredients)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    
                }

            }
            Console.WriteLine($"Total calories: {calories}");



        }
        
        
    }
}
