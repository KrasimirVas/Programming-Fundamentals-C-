using System;

namespace A1.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            double belt = priceLightsaber * Math.Ceiling(studentsCount * 1.1);
            double totalMoneyNeeds = belt+ (priceRobes * studentsCount) + priceBelt * (studentsCount - (studentsCount / 6));
            double need = totalMoneyNeeds - money;
            //Needed equipment for 2 padawans  :
            //sabresPrice * (studentsCount + 10 %) + robesPrice * (studentsCount) + beltsPrice * (studentsCount - freeBelts)
            //1 * (3) + 2 * (2) + 3 * (2) = 13.00
            //13.00 <= 100 – the money will be enough.

            if (money-totalMoneyNeeds>=0)
            {
               Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeds:F2}lv.");
             }
             else
            {
               Console.WriteLine($"Ivan Cho will need {need:f2}lv more.");
            }
            
        }
        //12*47=564
    }
}
