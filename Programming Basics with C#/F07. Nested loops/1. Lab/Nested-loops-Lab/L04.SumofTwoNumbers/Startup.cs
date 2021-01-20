using System;

namespace L04.SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;
            for (int i = startingNumber; i <= finalNumber; i++)
            {
                for (int j = startingNumber; j <= finalNumber; j++)
                {
                    combinations++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
                        isFound = true;
                        return;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
