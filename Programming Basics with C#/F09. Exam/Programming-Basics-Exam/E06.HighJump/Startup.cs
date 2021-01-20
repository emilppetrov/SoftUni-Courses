using System;

namespace E06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetBarHeight = int.Parse(Console.ReadLine());
            int currentBarHeight = targetBarHeight - 30;
            int totalJumps = 0;
            int failedAttempts = 0;
            bool hasFailed = false;
            while (hasFailed == false && targetBarHeight >= currentBarHeight)
            {
                int currentJumpHeight = int.Parse(Console.ReadLine());
                if (currentJumpHeight > currentBarHeight)
                {
                    failedAttempts = 0;
                    currentBarHeight += 5;
                }
                else
                {
                    failedAttempts++;
                    if (failedAttempts > 2)
                    {
                        hasFailed = true;
                    }
                }

                totalJumps++;
            }

            if (hasFailed)
            {
                Console.WriteLine($"Tihomir failed at {currentBarHeight}cm after {totalJumps} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {targetBarHeight}cm after {totalJumps} jumps.");
            }
        }
    }
}
