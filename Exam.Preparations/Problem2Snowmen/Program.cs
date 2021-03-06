﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem2Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            

            while (seq.Length>1)
            {
                List<int> losers = new List<int>();

                for (int attacker = 0; attacker < seq.Length; attacker++)
                {
                    int target = seq[attacker] % seq.Length;
                    int diff = Math.Abs(attacker - target);

                    if (seq.Length-losers.Count==1)
                    {
                        break;
                    }

                    if (losers.Contains(attacker))
                    {
                        continue;
                    }

                    if (attacker==target)
                    {
                        Console.WriteLine();
                        losers.Add(attacker);
                        seq[attacker] = -1;
                    }
                    else if (diff % 2==0)
                    {
                        Console.WriteLine();
                        losers.Add(target);
                        seq[target] = -1;
                    }
                    else
                    {
                        Console.WriteLine();
                        losers.Add(attacker);
                        seq[attacker] = -1;
                    }

                    losers = losers.Distinct().ToList();
                }
                seq = seq.Where(n => n != -1).ToArray();


            }



           
        }
    }
}
