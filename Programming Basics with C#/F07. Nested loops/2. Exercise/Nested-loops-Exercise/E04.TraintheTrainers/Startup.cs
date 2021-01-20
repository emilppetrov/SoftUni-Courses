using System;

namespace E04.TraintheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double sumAllGrades = 0;
            int countAllGrades = 0;
            while (presentation != "Finish")
            {
                double sum = 0;
                for (int i = 1; i <= countJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    sumAllGrades += grade;
                    countAllGrades++;
                }

                double average = sum / countJury;
                Console.WriteLine($"{presentation} - {average:F2}.");
                presentation = Console.ReadLine();
            }

            double averageAllGrades = sumAllGrades / countAllGrades;
            if (presentation == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {averageAllGrades:F2}.");
            }
        }
    }
}
