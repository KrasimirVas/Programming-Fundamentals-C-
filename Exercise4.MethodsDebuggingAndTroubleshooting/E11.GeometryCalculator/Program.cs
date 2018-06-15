using System;

namespace E11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            switch (figureType)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double heightTriangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}",TriangleArea(sideTriangle,heightTriangle));
                    break;
                case "square":
                    double sideSquere = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", SquereArea(sideSquere));
                    break;
                case "rectangle":
                    double widthRectangle = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", RectangleArea(widthRectangle,heightRectangle));
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CircleArea(radius));
                    break;
            }
            
        }
        static double TriangleArea(double sideTriangle, double heightTriangle)
        {
            double area = (sideTriangle * heightTriangle)/2;
            return area;
        }
        static double SquereArea(double sideSquere)
        {
            double area = sideSquere * sideSquere;
            return area;
        }
        static double RectangleArea(double widthRectangle, double heightRectangle)
        {
            double area = widthRectangle*heightRectangle;
            return area;
        }
        static double CircleArea(double radius)
        {
            double area = Math.PI * (radius * radius);
            return area;
        }


    }
}
