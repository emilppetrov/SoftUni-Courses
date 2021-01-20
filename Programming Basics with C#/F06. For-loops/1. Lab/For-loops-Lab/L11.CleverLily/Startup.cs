using System;

namespace L11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int singleToyPrice = int.Parse(Console.ReadLine());
            double birthdayMoneySum = 0;
            int evenBirthdaysCount = 0;
            int toysCount = 0;

            for (int birthdayNumber = 1; birthdayNumber <= age; birthdayNumber++)
            {
                if (birthdayNumber % 2 == 0)
                {
                    evenBirthdaysCount++;
                    birthdayMoneySum += evenBirthdaysCount * 10;
                }
                else
                {
                    toysCount++;
                }
            }

            int moneyFromSoldToys = toysCount * singleToyPrice;
            int moneyClaimedFromBrother = evenBirthdaysCount * 1;
            double resultingMoney = birthdayMoneySum + moneyFromSoldToys - moneyClaimedFromBrother;

            if (resultingMoney >= washingMachinePrice)
            {
                double leftOverMoney = resultingMoney - washingMachinePrice;
                Console.WriteLine($"Yes! {leftOverMoney:F2}");
            }
            else
            {
                double unsufficientMoney = washingMachinePrice - resultingMoney;
                Console.WriteLine($"No! {unsufficientMoney:F2}");
            }
        }
    }
}
