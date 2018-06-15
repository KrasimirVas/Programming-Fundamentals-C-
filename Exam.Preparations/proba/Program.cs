using System;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {


            string s = "STCDoghudd4=63333$D$0A53333";
            foreach (char c in s)
            {
                Console.Write((char)c-3);
                Console.WriteLine((int)c-3);
            }


        }
    }
}
