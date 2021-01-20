using System;

namespace E01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            bool isBigger = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    if (currentNumber > n)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }

                if (isBigger)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
