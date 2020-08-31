using System;

namespace E07.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double beerLitres = double.Parse(Console.ReadLine());
            double wineLitres = double.Parse(Console.ReadLine());
            double rakiaLitres = double.Parse(Console.ReadLine());
            double whiskeyLitres = double.Parse(Console.ReadLine());
            double priceRakia = priceWhiskey / 2;
            double priceWine = priceRakia - 0.40 * priceRakia;
            double priceBeer = priceRakia - 0.80 * priceRakia;
            double totalSum = whiskeyLitres * priceWhiskey + beerLitres * priceBeer + wineLitres * priceWine + rakiaLitres * priceRakia;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
