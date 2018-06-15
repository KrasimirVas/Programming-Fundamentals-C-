using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RetakeExam05January.P2Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();
            string forth = Console.ReadLine();
            string fifth = Console.ReadLine();

            string firstPattern = @"^[^A-Za-z0-9]+$";
            string secondPattern = @"^[0-9_]+$";
            string thirdPattern = @"[^A-Za-z0-9]+[0-9_]+([a-zA-Z]+)[0-9_]+";  //core =grupa 1
            string fourthPattern= @"^[0-9_]+$";
            string fifthPattern= @"^[^A-Za-z0-9]+$";
            Match firstrow = Regex.Match(first, firstPattern);
            Match secondrow = Regex.Match(second, secondPattern);
            Match thirdrow = Regex.Match(third, thirdPattern);
            Match fourthrow = Regex.Match(forth, fourthPattern);
            Match fifthrow = Regex.Match(fifth, fifthPattern);

            if (firstrow.Success && secondrow.Success && thirdrow.Success && fourthrow.Success && fifthrow.Success )
            {
                Console.WriteLine("Valid");
                Console.WriteLine(thirdrow.Groups[1].Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
