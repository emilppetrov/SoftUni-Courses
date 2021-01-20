using System;

namespace E02.RectangleofNxNStars
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
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}
