using System;

namespace E05.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;
            int trained = 0;
            int bought = 0;
            double percentTrained = 0;
            double percentBoughtProducts = 0;
            for (int i = 0; i < numberOfPeople; i++)
            {
                string person = Console.ReadLine();
                switch (person)
                {
                    case "Back":
                        back++;
                        trained++;
                        break;
                    case "Chest":
                        chest++;
                        trained++;
                        break;
                    case "Legs":
                        legs++;
                        trained++;
                        break;
                    case "Abs":
                        abs++;
                        trained++;
                        break;
                    case "Protein shake":
                        proteinShake++;
                        bought++;
                        break;
                    case "Protein bar":
                        proteinBar++;
                        bought++;
                        break;
                    default:
                        break;
                }
            }

            percentTrained = 100 / ((double)numberOfPeople / trained);
            percentBoughtProducts = 100 / ((double)numberOfPeople / bought);
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{percentTrained:F2}% - work out");
            Console.WriteLine($"{percentBoughtProducts:F2}% - protein");
        }
    }
}
