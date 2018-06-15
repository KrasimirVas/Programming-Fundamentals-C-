using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();


            while (input != "thetinggoesskrra")
            {
                string[] info = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (info.Length > 1)
                {
                    string dataKey = info[0];
                    long dataSize = long.Parse(info[1]);
                    string dataSet = info[2];

                    if (!dict.ContainsKey(dataSet))
                    {
                        dict[dataSet] = new Dictionary<string, long>();
                    }
                    if (!dict[dataSet].ContainsKey(dataKey))
                    {
                        dict[dataSet].Add(dataKey, dataSize);

                    }
                    else
                    {
                        dict[dataSet][dataKey] = dataSize;
                    }

                }

                input = Console.ReadLine();
            }
            if (dict.Count>1)
            {
                var maxValueSize = dict.OrderByDescending(x => x.Value.Sum(y => y.Value)).First();
                Console.WriteLine($"Data Set: {maxValueSize.Key}, Total Size: {maxValueSize.Value.Sum(x=>x.Value)}");

                foreach (var item in maxValueSize.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }

                //Data Set: Users, Total Size: 26233
            }
        }
    }
}
