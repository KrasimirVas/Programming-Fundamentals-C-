using System;

namespace E11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float totalTimeSec = (hours * 60 * 60) + (minutes * 60) + seconds;
            float totalMetersPerSecond = distance / totalTimeSec;
            float kilometers = distance / 1000;
            float totalHours = hours + (minutes / 60) + (seconds / 60 / 60);
            float kilometersPerHour = kilometers / totalHours;
            float totalMiles = kilometers / 1.609f;
            float totalMilesperHours = totalMiles / totalHours;


            Console.WriteLine($"{totalMetersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{totalMilesperHours}");
        }
    }
}
