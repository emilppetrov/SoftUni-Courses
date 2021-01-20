using System;

namespace E01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisRocketPrice = double.Parse(Console.ReadLine());
            double tennisRocketCount = double.Parse(Console.ReadLine());
            double sneackersCount = double.Parse(Console.ReadLine());
            double totalPriceRockets = tennisRocketCount * tennisRocketPrice;
            double priceForPairOfSneackers = tennisRocketPrice / 6;
            double totalSneakerPrice = sneackersCount * priceForPairOfSneackers;
            double restEquipmentPrice = (totalPriceRockets + totalSneakerPrice) * 0.2;
            double totalPrice = totalPriceRockets + totalSneakerPrice + restEquipmentPrice;
            double priceDjokovic = totalPrice / 8;
            double priceSponsors = totalPrice * 7 / 8;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceDjokovic)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceSponsors)}");
        }
    }
}
