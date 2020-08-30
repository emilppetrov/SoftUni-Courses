using System;

namespace E02.RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI; //Math.PI <-- π = 3.14159265359
            Console.WriteLine(Math.Round(degrees)); //Math.Round <-- integer
        }
    }
}
