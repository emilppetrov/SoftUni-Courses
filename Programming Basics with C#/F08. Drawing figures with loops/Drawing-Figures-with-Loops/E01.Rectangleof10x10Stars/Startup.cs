using System;

namespace E01.Rectangleof10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row <= 10; row++)
            {
                for (int col = 0; col <= 10; col++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}
