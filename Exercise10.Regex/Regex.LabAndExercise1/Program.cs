using System;
using System.Text.RegularExpressions;

namespace Reg.LabAndExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string text = Console.ReadLine();


            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match m in matches)
            {
                Console.Write(m.Value+ " ");
            }

        }
    }
}
