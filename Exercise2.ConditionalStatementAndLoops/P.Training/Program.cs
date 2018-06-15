using System;

namespace P.Training
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char toAvoid = char.Parse(Console.ReadLine());

            for (char i = first; i <=second; i++)
            {
                for (char j = first; j <=second; j++)
                {
                    for (char l = first; l <=second; l++)
                    {
                        if (i!=toAvoid && j!=toAvoid && l!=toAvoid )
                        {
                            Console.Write($"{i}{j}{l} ");
                        }
                    }
                }
            }

        }


    }
}
        
            
	

	


        
        
			
