using System;

namespace E03.SquareofStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row <= n - 1; row++)
            {
                for (int col = 0; col <= n - 1; col++)
                {
                    Console.Write('*' + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
