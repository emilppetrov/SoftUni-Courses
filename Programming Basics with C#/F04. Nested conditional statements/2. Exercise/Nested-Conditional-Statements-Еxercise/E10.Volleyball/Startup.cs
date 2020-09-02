using System;

namespace E10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());
            double sweekends = 48 - weekends;
            double playdays = (sweekends * 3.0 / 4) + (holidays * 2.0 / 3) + weekends;
            if (year == "normal")
            {
                Console.WriteLine($"{Math.Floor(playdays)}:F2");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(playdays * 0.15 + playdays)}:F2");
            }
        }
    }
}
