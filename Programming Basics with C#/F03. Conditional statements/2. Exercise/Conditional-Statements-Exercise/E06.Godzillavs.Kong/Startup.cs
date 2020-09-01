using System;

namespace E06.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double actors = double.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());
            double decoration = budget * 0.1;
            double clothesPrice = actors * clothes;
            double totalPrice = decoration + clothesPrice;
            if (actors > 150)
            {
                double discount = clothesPrice * 0.1;
                double newClothesPrice = clothesPrice - discount;
                totalPrice = decoration + newClothesPrice;
            }

            if (totalPrice > budget)
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
            else if (totalPrice <= budget)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
