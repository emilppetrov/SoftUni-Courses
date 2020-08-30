using System;

namespace E08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = length * width * height;
            double liters = volume * 0.001;
            double percentConvert = percent * 0.01;
            double litersNeeded = liters * (1 - percentConvert);
            Console.WriteLine($"{litersNeeded:F3}");
        }
    }
}
