using System;

namespace E10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int LeftRight = (n - 1) / 2;
            int Middle = 0;
            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', LeftRight),
                        new string('-', Middle));
                    LeftRight--;
                    Middle += 2;
                }

                int LeftRightToDown = 1;
                int MiddleDown = Middle - 4;
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', LeftRightToDown),
                        new string('-', MiddleDown));
                    LeftRightToDown++;
                    MiddleDown -= 2;
                }
            }
            else
            {
                Console.WriteLine("{0}*{0}", new string('-', LeftRight));
                LeftRight--;
                Middle = 1;
                for (int i = 0; i < (n / 2); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', LeftRight),
                        new string('-', Middle));
                    LeftRight--;
                    Middle += 2;
                }

                int LeftRight2Down = 1;
                int MiddleDown = Middle - 4;
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', LeftRight2Down),
                        new string('-', MiddleDown));
                    LeftRight2Down++;
                    MiddleDown -= 2;
                }

                if (n == 1)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
                }
            }
        }
    }
}
