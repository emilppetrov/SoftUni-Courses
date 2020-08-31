using System;

namespace L07.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardGreening = double.Parse(Console.ReadLine());
            double yardPrice = yardGreening * 7.61;
            double discount = yardPrice * 18 / 100;
            double totalPrice = yardPrice - discount;
            Console.WriteLine($"The final price is: {totalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
