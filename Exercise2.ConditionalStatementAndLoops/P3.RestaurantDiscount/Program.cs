using System;

namespace P3.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double price = 0;

            if (guests > 120) 
            {
                Console.WriteLine($"We do not have an appropriate hall.");
                return;
            }
            else if (guests>0 && guests<=50)
            {
                hall = "Small Hall";
                price += 2500;
            }
            else if (guests>50 && guests <=100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (true)
            {
                hall = "Great Hall";
                price = 7500;
            }
            switch (package)
            {
                case "Normal":
                    price =(price+ 500) * 0.95;
                    break;
                case "Gold":
                    price =(price + 750) * 0.90;
                    break;
                case "Platinum":
                    price =(price+ 1000) * 0.85;
                    break;
               
            }
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {price/guests:F2}$");
        }
    }
}
