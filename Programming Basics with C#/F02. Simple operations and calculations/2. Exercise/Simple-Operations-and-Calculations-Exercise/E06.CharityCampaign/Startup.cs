using System;

namespace E06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double campaign = double.Parse(Console.ReadLine());
            double bakers = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double waffles = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());
            double cakesPrice = cakes * 45;
            double wafflesPrice = waffles * 5.80;
            double pancakesPrice = pancakes * 3.20;
            double sum = (cakesPrice + wafflesPrice + pancakesPrice) * bakers;
            double totalSum = sum * campaign;
            double sumAfterExpenses = totalSum - totalSum / 8;
            Console.WriteLine(sumAfterExpenses);
        }
    }
}
