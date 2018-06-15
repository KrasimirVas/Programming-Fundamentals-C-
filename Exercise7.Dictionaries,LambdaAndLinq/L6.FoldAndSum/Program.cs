using System;
using System.Linq;

namespace L6.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] row1Left = numbers.Take(k).Reverse().ToArray();
            int[] row1Right = numbers.Reverse().Take(k).ToArray();
            int[] row1 = row1Left.Concat(row1Right).ToArray();
            int[] row2 = numbers.Skip(k).Take(2 * k).ToArray();

            var result = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", result));




        }
    }
}
