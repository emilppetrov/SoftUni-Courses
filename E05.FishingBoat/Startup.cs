using System;

namespace E05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double rent = 0;
            double totalSum = 0;
            if (season == "Spring")
            {
                rent = 3000;
                if (fishermen <= 6)
                {
                    totalSum = rent - (rent * 0.10);
                }
                else if (fishermen >= 7 && fishermen <= 11)
                {
                    totalSum = rent - (rent * 0.15);
                }
                else if (fishermen >= 12)
                {
                    totalSum = rent - (rent * 0.25);
                }

                if (fishermen % 2 == 0)
                {
                    totalSum = totalSum - (totalSum * 0.05);
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {

                rent = 4200;
                if (fishermen <= 6)
                {
                    totalSum = rent - (rent * 0.10);
                }
                else if (fishermen >= 7 && fishermen <= 11)
                {
                    totalSum = rent - (rent * 0.15);
                }
                else if (fishermen >= 12)
                {
                    totalSum = rent - (rent * 0.25);
                }

                if (fishermen % 2 == 0 && season != "Autumn")
                {
                    totalSum = totalSum - (totalSum * 0.05);
                }

            }
            else if (season == "Winter")
            {
                rent = 2600;
                if (fishermen <= 6)
                {
                    totalSum = rent - (rent * 0.10);
                }
                else if (fishermen >= 7 && fishermen <= 11)
                {
                    totalSum = rent - (rent * 0.15);
                }
                else if (fishermen >= 12)
                {
                    totalSum = rent - (rent * 0.25);
                }

                if (fishermen % 2 == 0)
                {
                    totalSum = totalSum - (totalSum * 0.05);
                }
            }

            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                double neededMoney = Math.Abs(budget - totalSum);
                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
            }
        }
    }
}
