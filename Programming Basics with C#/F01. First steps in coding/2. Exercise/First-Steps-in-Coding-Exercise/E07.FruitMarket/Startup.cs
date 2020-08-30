using System;

namespace E07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());
            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice - 0.4 * raspberriesPrice;
            double bananasPrice = raspberriesPrice - 0.8 * raspberriesPrice;
            double strawberriesTotalPrice = strawberries * strawberriesPrice;
            double bananasTotalPrice = raspberries * raspberriesPrice;
            double orangesTotalPrice = oranges * orangesPrice;
            double raspberriesTotalPrice = bananas * bananasPrice;
            double totalPrice = strawberriesTotalPrice + bananasTotalPrice + orangesTotalPrice + raspberriesTotalPrice;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
