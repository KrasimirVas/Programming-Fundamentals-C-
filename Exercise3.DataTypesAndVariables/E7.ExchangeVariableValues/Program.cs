﻿using System;

namespace E7.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");


            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");

        }
    }
}
