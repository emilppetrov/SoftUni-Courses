using System;

namespace E02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int seats = rows * columns;
            double priceOfTicket = 0;
            if (typeOfMovie == "Premiere")
            {
                priceOfTicket = 12;
            }
            else if (typeOfMovie == "Normal")
            {
                priceOfTicket = 7.50;
            }
            else if (typeOfMovie == "Discount")
            {
                priceOfTicket = 5;
            }

            double totalPrice = priceOfTicket * seats;
            Console.WriteLine($"{totalPrice:F2} leva");
        }
    }
}
