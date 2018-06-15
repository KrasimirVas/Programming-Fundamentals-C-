using System;

namespace E3.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            PrintNameOfLastDigit(number);


        }
        static void PrintNameOfLastDigit(long number)
        {
            string nameOfLastDigit = "";
            long LastDigit = number % 10;
                            
                switch (LastDigit)
                {
                    case 1: nameOfLastDigit = "one";
                        break;
                    case 2:
                        nameOfLastDigit = "two";
                        break;
                    case 3:
                        nameOfLastDigit = "three";
                        break;
                    case 4:
                        nameOfLastDigit = "four";
                        break;
                    case 5:
                        nameOfLastDigit = "five";
                        break;
                    case 6:
                        nameOfLastDigit = "six";
                        break;
                    case 7:
                        nameOfLastDigit = "seven";
                        break;
                    case 8:
                        nameOfLastDigit = "eight";
                        break;
                    case 9:
                        nameOfLastDigit = "nine";
                        break;
                    case 0:
                        nameOfLastDigit = "zero";
                        break;
                                           
                }
            Console.WriteLine(nameOfLastDigit);
        }
            

        }
    }

