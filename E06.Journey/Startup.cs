using System;

namespace E06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string placeToStay = "";
            double price = 0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    placeToStay = "Camp";
                    price = 0.30 * budget;
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    price = 0.70 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    placeToStay = "Camp";
                    price = 0.40 * budget;
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    price = 0.80 * budget;
                }
            }
            else
            {
                destination = "Europe";
                placeToStay = "Hotel";
                price = 0.90 * budget;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {price:F2}");
        }
    }
}
