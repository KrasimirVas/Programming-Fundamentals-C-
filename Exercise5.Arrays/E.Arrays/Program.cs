using System;
using System.Linq;

namespace E.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word1 = Console.ReadLine().Split(' ').ToArray();
            string[] word2 = Console.ReadLine().Split(' ').ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (word1[i]==word2[i])
                {
                    leftSum++;
                }
                else
                {
                    break;    
                }
            }
            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (word1[word1.Length-1-i]==word2[word2.Length-1-i])
                {
                    rightSum++;
                }
                else
                {
                    break;
                }

            }
            if (leftSum>rightSum)
            {
                Console.WriteLine(leftSum);
            }
            else
            {
                Console.WriteLine(rightSum);
            }

        }
    }
}
