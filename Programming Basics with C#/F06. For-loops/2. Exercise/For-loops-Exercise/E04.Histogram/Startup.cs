using System;

namespace E04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    counter1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    counter2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    counter3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    counter4++;
                }
                else if (num >= 800)
                {
                    counter5++;
                }
            }

            double p1 = (counter1 * 1.0 / numbers) * 100;
            double p2 = (counter2 * 1.0 / numbers) * 100;
            double p3 = (counter3 * 1.0 / numbers) * 100;
            double p4 = (counter4 * 1.0 / numbers) * 100;
            double p5 = (counter5 * 1.0 / numbers) * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
