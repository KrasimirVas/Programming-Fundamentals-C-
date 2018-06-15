using System;

namespace P14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char charToAvoid = char.Parse(Console.ReadLine());
            
            for (char i = one; i <=two; i++)
            {
                for (char j = one; j <= two; j++)
                {
                    for (char k = one; k <= two; k++)
                    {
                        
                        if (i!=charToAvoid && j!=charToAvoid && k!=charToAvoid)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
