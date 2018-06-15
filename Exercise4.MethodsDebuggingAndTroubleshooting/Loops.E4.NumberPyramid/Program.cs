﻿using System;

namespace Loops.E4.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;

            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(current+" ");
                    current++;
                    if (current>n)
                    {
                        return;
                    }
                }
                Console.WriteLine();


            }
        }
    }
}
