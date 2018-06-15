using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace A4.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> dict = new Dictionary<string, string>();


            while (input != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    string[] line = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = line[0];
                    string user = line[1];

                    if (!dict.ContainsKey(side))
                    {
                        dict.Add(side, user);
                       
                    }
                    

                }
                else if (input.Contains(" -> "))
                {
                    string[] line = input.Split(new char[] { ' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = line[1];
                    string user = line[0];

                    if (dict.ContainsValue(user))
                    {
                        dict.Remove(user);
                        dict.Add(side, user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        dict.Add(side, user);
                        
                    }
                    
                }


                


                input = Console.ReadLine();
            }
            if (dict.Values.Count>0)
            {
                foreach (var pair in dict.OrderByDescending(x => x.Value.Count()).ThenBy(t => t.Key))
                {

                    Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.}");
                    Console.WriteLine($"! {string.Join("", pair.Value.OrderBy(s => s))}");

                }
            }
            
        }
    }
}
