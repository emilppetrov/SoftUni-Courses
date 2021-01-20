using System;

namespace L05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            double balance = 0.0;
            while (counter < number)
            {
                double amount = double.Parse(Console.ReadLine());

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                balance += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                counter++;
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
