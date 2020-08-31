using System;

namespace E03._2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read coordinats x1, y1, x2, y2
            double x1 = double.Parse(Console.ReadLine()); //60
            double y1 = double.Parse(Console.ReadLine()); //20
            double x2 = double.Parse(Console.ReadLine()); //10
            double y2 = double.Parse(Console.ReadLine()); //50
            //Calculate lenght = x1 - x2
            double lenght = Math.Abs(x1 - x2);
            //Calculate width = y1 - y2
            double width = Math.Abs(y1 - y2);
            //Calculate area lenght * width
            double area = lenght * width;
            //Calculate per = 2 * (len + wid)
            double perimeter = 2 * (lenght + width);
            //Print
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
