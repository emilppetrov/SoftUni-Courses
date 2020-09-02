using System;

namespace E08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double studioPrice = 50;
            double apartmentPrice = 65;
            double studioDiscount = 0.00;
            double apartmentDiscount = 0.00;
            switch (month)
            {
                case "May":
                case "October":
                    if (nights > 7)
                    {
                        studioDiscount = 0.05;
                    }

                    if (nights > 14)
                    {
                        studioDiscount = 0.30;
                        apartmentDiscount = 0.10;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (nights > 14)
                    {
                        studioDiscount = 0.20;
                        apartmentDiscount = 0.10;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76.00;
                    apartmentPrice = 77.00;
                    if (nights > 14)
                    {
                        apartmentDiscount = 0.10;
                    }
                    break;
                default:
                    Console.WriteLine("Off Season");
                    break;
            }

            double totalStudioMoney = studioPrice * nights;
            double finalStudioMoney = totalStudioMoney - (totalStudioMoney * studioDiscount);
            double totalApartmentMoney = apartmentPrice * nights;
            double finalApartmentMoney = totalApartmentMoney - (totalApartmentMoney * apartmentDiscount);
            Console.WriteLine($"Apartment: {finalApartmentMoney:f2} lv.");
            Console.WriteLine($"Studio: {finalStudioMoney:f2} lv.");
        }
    }
}
