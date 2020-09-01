using System;

namespace L07.AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0.0;
            switch (figureType)
            {
                case "square":
                    {
                        double a = double.Parse(Console.ReadLine());
                        area = a * a;
                        Console.WriteLine("{0:F3}", area);
                        break;
                    }
                case "rectangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        area = a * b;
                        Console.WriteLine("{0:F3}", area);
                        break;
                    }
                case "circle":
                    {
                        double r = double.Parse(Console.ReadLine());
                        area = Math.PI * r * r;
                        Console.WriteLine("{0:F3}", area);
                        break;
                    }
                case "triangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        area = a * h / 2;
                        Console.WriteLine("{0:F3}", area);
                        break;
                    }
            }
        }
    }
}
