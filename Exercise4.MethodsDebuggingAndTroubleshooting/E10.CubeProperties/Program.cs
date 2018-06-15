using System;

namespace E10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0;
            switch (parameter)
            {
                case "face":
                    result = GetCubeFace(side);
                    break;
                case "space":
                    result = GetCubeSpace(side);
                    break;
                case "volume":
                    result = GetCubeVolume(side);
                    break;
                case "area":
                    result = GetCubeArea(side);
                    break;
            
            }
            Console.WriteLine($"{result:f2}");

        }
        static double GetCubeFace(double side)
        {
            double face = Math.Sqrt(2 * (side * side));
            return face;
        }
        static double GetCubeSpace(double side)
        {
            double space = Math.Sqrt(3 * (side * side));
            return space;
        }
        static double GetCubeVolume(double side)
        {
            double volume = side*side*side;
            return volume;
        }
        static double GetCubeArea(double side)
        {
            double area = 6 * (side * side);
            return area;
        }
    }
}
