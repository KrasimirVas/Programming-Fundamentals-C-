﻿using System;

namespace P9._CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int counter = 0;

            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);

            }

        }
    }
}
