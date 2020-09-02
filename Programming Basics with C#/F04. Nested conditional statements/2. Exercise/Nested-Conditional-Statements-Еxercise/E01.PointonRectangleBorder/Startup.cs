using System;

namespace E01.PointonRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool xEqual = x == x1 || x == x2;
            bool yBetween = y >= y1 && y <= y2;
            bool firstCheck = xEqual && yBetween;
            bool yEqual = y == y1 || y == y2;
            bool xBetween = x >= x1 && x <= x2;
            bool secondCheck = yEqual && xBetween;

            if (firstCheck || secondCheck)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
