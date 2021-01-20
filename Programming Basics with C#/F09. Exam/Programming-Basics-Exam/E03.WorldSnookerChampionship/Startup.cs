using System;

namespace E03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfChampionship = Console.ReadLine();
            string typeOfTicket = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            string photoWithTrophyString = Console.ReadLine();
            bool photoWithTrophy = false;
            if (photoWithTrophyString == "Y")
            {
                photoWithTrophy = true;
            }
            else if (photoWithTrophyString == "N")
            {
                photoWithTrophy = false;
            }

            double priceOfTicket = 0;
            double totalPrice = 0;
            switch (typeOfChampionship)
            {
                case "Quarter final":
                    if (typeOfTicket == "Standard")
                    {
                        priceOfTicket = 55.50;
                    }
                    else if (typeOfTicket == "Premium")
                    {
                        priceOfTicket = 105.20;
                    }
                    else if (typeOfTicket == "VIP")
                    {
                        priceOfTicket = 118.90;
                    }
                    break;
                case "Semi final":
                    if (typeOfTicket == "Standard")
                    {
                        priceOfTicket = 75.88;
                    }
                    else if (typeOfTicket == "Premium")
                    {
                        priceOfTicket = 125.22;
                    }
                    else if (typeOfTicket == "VIP")
                    {
                        priceOfTicket = 300.40;
                    }
                    break;
                case "Final":
                    if (typeOfTicket == "Standard")
                    {
                        priceOfTicket = 110.10;
                    }
                    else if (typeOfTicket == "Premium")
                    {
                        priceOfTicket = 160.66;
                    }
                    else if (typeOfTicket == "VIP")
                    {
                        priceOfTicket = 400;
                    }
                    break;
                default:
                    break;
            }

            totalPrice = priceOfTicket * numberOfTickets;
            if (totalPrice > 4000)
            {
                totalPrice -= totalPrice / 100 * 25;
                photoWithTrophy = false;
            }
            else if (totalPrice > 2500)
            {
                totalPrice -= totalPrice / 100 * 10;
            }

            if (photoWithTrophy)
            {
                totalPrice += numberOfTickets * 40;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
