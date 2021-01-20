using System;

namespace E09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int roof2 = 2;
            int roof1 = 1;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}",
                       new string('-', ((n - 2) / 2) - i),
                       new string('*', roof2)
                       );
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}",
                    new string('-', ((n - 1) / 2) - i),
                    new string('*', roof1)
                    );
                }
                roof2 += 2;
                roof1 += 2;
            }
            roof2 -= 4;
            roof1 -= 4;
            for (int i = 0; i < n / 2; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("|{0}|",
                       new string('*', roof2)
                       );
                }
                else
                {
                    Console.WriteLine("|{0}|",
                    new string('*', roof1)
                    );
                }
            }
        }
    }
}
