using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();

            switch (profession)
            {
                case "Athlete":
                
                    Console.WriteLine("Water");
                    break;
                case "Businesswoman":
                case "Businessman":

                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;

                default:
                    Console.WriteLine("Tea");

                    break;
            }
        }
    }
}
