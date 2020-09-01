using System;

namespace E08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0;
            double excellentResultsScholarship = 0;
            if (income < minimumSalary && averageGrade >= 4.50)
            {
                socialScholarship = minimumSalary * 0.35;
            }

            if (averageGrade >= 5.50)
            {
                excellentResultsScholarship = averageGrade * 25;
            }

            if (socialScholarship == 0 && excellentResultsScholarship == 0)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else if (excellentResultsScholarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentResultsScholarship)} BGN");
            }
            else if (socialScholarship > excellentResultsScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
        }
    }
}
