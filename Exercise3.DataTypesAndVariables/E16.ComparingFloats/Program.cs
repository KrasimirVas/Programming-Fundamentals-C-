using System;

namespace E16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double diffrence = Math.Max(a, b) - Math.Min(a, b);
            bool isEqualEps = false;

            if (diffrence<=eps)
            {
                isEqualEps= true;
                Console.WriteLine(isEqualEps);
            }
            else
            {
                isEqualEps = false;
                Console.WriteLine(isEqualEps);
            }
        }
    }
}
