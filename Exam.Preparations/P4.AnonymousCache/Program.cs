using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _P4.AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {

                string[] info = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (info.Length > 1)
                {
                    string dataKey = info[0];
                    long size = long.Parse(info[1]);
                    string dataSet = info[2];

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }
                    if (!data[dataSet].ContainsKey(dataKey))
                    {
                        data[dataSet].Add(dataKey, size);
                    }
                    else
                    {
                        data[dataSet][dataKey] = size;
                    }
                    
                }       
                
                input = Console.ReadLine();
            }

            if (data.Count>1)
            {
                var dataMaxValue = data.OrderByDescending(s => s.Value.Sum(d => d.Value)).First();

                Console.WriteLine($"Data Set: {dataMaxValue.Key}, Total Size: {dataMaxValue.Value.Sum(d => d.Value)}");

                foreach (var item in dataMaxValue.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
          

        }
    }
}
