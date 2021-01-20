using System;

namespace E06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int wight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int areaCake = wight * lenght;
            int areaOnePiece = 1;
            int areaTotalPieces = 0;
            int counterPieces = 0;
            int pieces = 0;
            bool isThereEnoughCake = true;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                pieces = int.Parse(input);
                counterPieces += pieces;

                areaTotalPieces = areaOnePiece * counterPieces;

                if (areaCake < areaTotalPieces)
                {
                    int neededPieces = areaTotalPieces - areaCake;
                    Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
                    isThereEnoughCake = false;
                    break;
                }

                input = Console.ReadLine();
            }

            if (isThereEnoughCake == true)
            {
                int leftOver = areaCake - areaTotalPieces;
                Console.WriteLine($"{leftOver} pieces are left.");
            }
        }
    }
}
