using System;

namespace L5.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            double celcius = FahrenheitToCelsius(degrees);
            Console.WriteLine($"{celcius:f2}");
        }

        static double FahrenheitToCelsius(double degrees)
        {
            return (degrees - 32) * 5 / 9;
        }
    }
}
