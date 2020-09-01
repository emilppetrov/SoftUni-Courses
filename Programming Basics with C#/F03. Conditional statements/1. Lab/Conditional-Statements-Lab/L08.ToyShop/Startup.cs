using System;

namespace L08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());
            double totalSum = puzzlesCount * 2.60 + dollsCount * 3 + bearsCount * 4.10 + minionsCount * 8.20 + trucksCount * 2;
            int totalCount = puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount;
            if (totalCount >= 50)
            {
                double discount = totalSum * 0.25;
                totalSum = totalSum - discount;
            }

            totalSum = totalSum - 0.1 * totalSum;
            if (totalSum >= tripPrice)
            {
                double leftMoney = totalSum - tripPrice;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else
            {
                double needMoney = tripPrice - totalSum;
                Console.WriteLine($"Not enough money! {needMoney:F2} lv needed.");
            }
        }
    }
}
