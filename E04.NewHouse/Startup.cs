using System;

namespace E04.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceForOneFlower = 0;
            if (typeOfFlowers == "Roses")
            {
                priceForOneFlower = 5;
            }
            else if (typeOfFlowers == "Dahlias")
            {
                priceForOneFlower = 3.80;
            }
            else if (typeOfFlowers == "Tulips")
            {
                priceForOneFlower = 2.80;
            }
            else if (typeOfFlowers == "Narcissus")
            {
                priceForOneFlower = 3;
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                priceForOneFlower = 2.50;
            }

            double totalPrice = flowersCount * priceForOneFlower;

            if (flowersCount > 80 && typeOfFlowers == "Roses")
            {
                totalPrice = totalPrice - 0.10 * totalPrice;
            }
            else if (flowersCount > 90 && typeOfFlowers == "Dahlias")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (flowersCount > 80 && typeOfFlowers == "Tulips")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (flowersCount < 120 && typeOfFlowers == "Narcissus")
            {
                totalPrice = totalPrice + 0.15 * totalPrice;
            }
            else if (flowersCount < 80 && typeOfFlowers == "Gladiolus")
            {
                totalPrice = totalPrice + 0.20 * totalPrice;
            }

            if (budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeOfFlowers} and {leftMoney:F2} leva left.");
            }
            else
            {
                double needMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
            }
        }
    }
}
