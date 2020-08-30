using System;

namespace E03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double monthlyIncrease = deposit * percentage * 0.01 / 12;
            double sum = deposit + month * monthlyIncrease;
            Console.WriteLine(sum);
        }
    }
}
