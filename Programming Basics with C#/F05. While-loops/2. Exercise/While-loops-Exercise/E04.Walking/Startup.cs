using System;

namespace E04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 10000;
            int walkedSteps = 0;
            string steps = Console.ReadLine();
            while (true)
            {
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    walkedSteps += int.Parse(steps);
                    break;
                }
                else
                {
                    walkedSteps += int.Parse(steps);
                }

                if (walkedSteps >= target)
                {
                    break;
                }

                steps = Console.ReadLine();
            }

            if (walkedSteps >= target)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{target - walkedSteps} more steps to reach goal.");
            }
        }
    }
}
