using System;

namespace E02.RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Read radians
            double radians = double.Parse(Console.ReadLine());
            //2. Calculate degrees -> radians * 180 / pi
            double degrees = radians * 180 / Math.PI;
            //3. Print -> round
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
