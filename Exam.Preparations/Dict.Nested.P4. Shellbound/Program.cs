using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict.Nested.P4._Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, HashSet<int>> dict = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                string[] currentLine = input.Split(' ').ToArray();
                string city = currentLine[0];
                int size = int.Parse(currentLine[1]);
                if (!dict.ContainsKey(city))
                {
                    dict[city] = new HashSet<int>();
                }
                dict[city].Add(size);         

                input = Console.ReadLine();
            }

            foreach (var item in dict.Keys)
            {
                if (dict[item].Count!=1)
                {
                    int ValuesSum = dict[item].Sum();
                    int countOfShells = dict[item].Count;
                    int giantShell = ValuesSum - (ValuesSum / countOfShells);
                    Console.WriteLine($"{item} -> {string.Join(", ", dict[item])} ({giantShell})");
                }
                else
                {
                    Console.WriteLine($"{item} -> {string.Join(", ", dict[item])} ({dict[item]})");
                }
                
            }
        }
    }
}
