using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P1.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowball = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValueMax = 0;
            BigInteger snowBallValue = 0;
            //snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})
            int snowballSnowMax = 0;
            int snowballTimeMax = 0;
            long snowballQualityMax = 0;

            for (int i = 0; i < snowball; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowBallValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowBallValue>=snowballValueMax)
                {
                    snowballValueMax = snowBallValue;
                    snowballSnowMax = snowballSnow;
                    snowballTimeMax = snowballTime;
                    snowballQualityMax = snowballQuality;


                }
            }
            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValueMax} ({snowballQualityMax})");
        }
    }
}
