using System;

namespace E04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            double pages = double.Parse(Console.ReadLine());
            double pagesInHour = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double time = (pages / pagesInHour) / days;
            Console.WriteLine(time);
        }
    }
}
