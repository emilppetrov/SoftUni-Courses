using System;

namespace L10.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());
            int freeSpaceTotal = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                if (freeSpaceTotal < boxes)
                {
                    Console.WriteLine($"No more free space! You need {boxes - freeSpaceTotal} Cubic meters more.");
                    break;
                }

                freeSpaceTotal -= boxes;
                input = Console.ReadLine();
            }

            if (input == "Done")
            {
                Console.WriteLine($"{freeSpaceTotal} Cubic meters left.");
            }
        }
    }
}
