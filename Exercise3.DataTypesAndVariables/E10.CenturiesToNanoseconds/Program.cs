using System;

namespace E10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            decimal hours = days * 24m;
            decimal minutes = hours * 60m;
            decimal seconds = minutes * 60m;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {seconds}000 milliseconds = {seconds}000000 microseconds = {seconds}000000000 nanoseconds");



           
        }
    }
}
