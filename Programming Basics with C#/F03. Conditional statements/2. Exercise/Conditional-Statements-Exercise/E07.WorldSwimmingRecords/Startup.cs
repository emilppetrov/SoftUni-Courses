using System;

namespace E07.WorldSwimmingRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSeconds = double.Parse(Console.ReadLine());
            double mustSwim = distanceMeters * timeSeconds;
            double addTime = (Math.Floor(distanceMeters / 15)) * 12.5;
            double totalTime = Math.Abs(mustSwim + addTime);
            if (recordSeconds <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordSeconds:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
        }
    }
}
