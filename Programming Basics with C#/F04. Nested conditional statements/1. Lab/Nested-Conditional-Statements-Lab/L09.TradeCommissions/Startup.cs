using System;

namespace L09.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = -1.0;

            bool sofia = city == "Sofia";
            bool varna = city == "Varna";
            bool plovdiv = city == "Plovdiv";
            bool check1 = sales >= 0 && sales <= 500;
            bool check2 = sales > 500 && sales <= 1000;
            bool check3 = sales > 1000 && sales <= 10000;
            bool check4 = sales > 10000;

            if (sofia)
            {
                if (check1)
                {
                    commision = 0.05;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (check2)
                {
                    commision = 0.07;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (check3)
                {
                    commision = 0.08;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (check4)
                {
                    commision = 0.12;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (varna)
            {
                if (check1)
                {
                    commision = 0.045;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (check2)
                {
                    commision = 0.075;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (check3)
                {
                    commision = 0.1;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (check4)
                {
                    commision = 0.13;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (plovdiv)
            {
                if (check1)
                {
                    commision = 0.055;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (check2)
                {
                    commision = 0.08;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (check3)
                {
                    commision = 0.12;
                    double totalPrice = sales * commision;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (check4)
                {
                    commision = 0.145;
                    double totalPrice = sales * commision;
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
