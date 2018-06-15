using System;

namespace Exam.Preparation.Pokemon._09._07._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            decimal halfPower = power * 0.5m;
            int counter = 0;

            while (power>=distance)
            {
                power -= distance;
                counter++;                 
                

                if (power == halfPower && exhaustion > 0)
                {
                    power = power / exhaustion;
                }

            }
            Console.WriteLine(power);
            Console.WriteLine(counter);




        }
    }
}
