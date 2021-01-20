using System;

namespace E06.RhombusofStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            for (int row = 0; row < side; row++)
            {
                Console.Write(new string(' ', side - row - 1));
                for (int numberOfSymbols = 0; numberOfSymbols <= row; numberOfSymbols++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int row = side - 1; row > 0; row--)
            {
                Console.Write(new string(' ', side - row));
                for (int numberOfSymbols = row; numberOfSymbols > 0; numberOfSymbols--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
