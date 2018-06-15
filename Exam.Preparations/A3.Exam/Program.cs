using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace A3.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMessege = int.Parse(Console.ReadLine());

            string patterndecrypt = @"[sStTaArR]";
            string textnew = "";
            List<char> inputchar = new List<char>();


            for (int i = 0; i < numberMessege; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(patterndecrypt);
                MatchCollection mathes = regex.Matches(input);

                int mathesCount = mathes.Count();
                for (int j = 0; j < input.Length; j++)
                {
                    inputchar.Add(input[j]);
                }

                
               
                


              
            }

            
        }
    }
}
