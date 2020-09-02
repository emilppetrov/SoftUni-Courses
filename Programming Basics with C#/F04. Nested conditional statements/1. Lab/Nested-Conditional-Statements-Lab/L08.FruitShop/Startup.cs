using System;

namespace L08.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double counter = double.Parse(Console.ReadLine());
            double price = 0;
            bool dayCheck = day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday";
            bool dayCheck2 = day == "saturday" || day == "sunday";
            if (dayCheck)
            {
                if (fruit == "banana")
                {
                    price = 2.50;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (dayCheck2)
            {
                if (fruit == "banana")
                {
                    price = 2.70;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                    double totalPrice = counter * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
