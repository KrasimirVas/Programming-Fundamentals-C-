using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict.Nested.P2._2.KeyKeyValueValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyToSeach = Console.ReadLine();
            string valueToSeach = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string key = tokens[0];
                string[] values = tokens[1].Split(';');

                if (key.Contains(keyToSeach))
                {
                    Console.WriteLine($"{key}:");
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (values[j].Contains(valueToSeach))
                        {
                            Console.WriteLine($"-{values[j]}");
                        }
                    }
                }
            }


        }
    }
}
