using System;
using System.Collections.Generic;
using System.Linq;

namespace E4.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailbook = new Dictionary<string, string>();
            string name = "";
            string email = "";
            string commands = Console.ReadLine();

            while (commands != "stop")
            {
                name = commands;
                email = Console.ReadLine();

                if (!mailbook.ContainsKey(name))
                {
                    mailbook.Add(name, email);
                }
                commands = Console.ReadLine();

            }
            foreach (var pair in mailbook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
