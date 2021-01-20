using System;

namespace E02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesControla = int.Parse(Console.ReadLine());
            int secondsControla = int.Parse(Console.ReadLine());
            double lengthInMeters = double.Parse(Console.ReadLine());
            int secondsToPass = int.Parse(Console.ReadLine());
            double controlaInSeconds = minutesControla * 60 + secondsControla;
            double timeDecreases = lengthInMeters / 120;
            double totalTimeDecrease = timeDecreases * 2.5;
            double timeMarin = (lengthInMeters / 100) * secondsToPass - totalTimeDecrease;
            if (timeMarin <= controlaInSeconds)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMarin:F3}.");
            }
            else if (timeMarin > controlaInSeconds)
            {
                double timeNeeded = timeMarin - controlaInSeconds;
                Console.WriteLine($"No, Marin failed! He was {timeNeeded:F3} second slower.");
            }
        }
    }
}
