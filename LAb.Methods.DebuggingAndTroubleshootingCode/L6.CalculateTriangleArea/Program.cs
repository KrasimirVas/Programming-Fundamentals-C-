﻿using System;

namespace L6.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleArea(width, height));
        }

        static double TriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
