using System;

namespace LoopsE2._Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int wing = n - 2;

            for (int i = 1; i <= n-2; i++)
            {
                if (i % 2==1)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*',wing));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', wing));
                }
            }
            Console.WriteLine("{0}@", new string(' ', wing + 1));
            for (int i = 1; i <= n-2; i++)
            {
                if (i % 2==1)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', wing));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', wing));
                }
            }

        }
    }
}
