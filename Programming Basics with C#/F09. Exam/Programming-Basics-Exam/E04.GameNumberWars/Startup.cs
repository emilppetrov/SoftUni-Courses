using System;

namespace E04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1Name = Console.ReadLine();
            string player2Name = Console.ReadLine();
            int player1Points = 0;
            int player2Points = 0;
            string input;
            bool numberWars = false;
            while (!numberWars && (input = Console.ReadLine()) != "End of game")
            {
                int player1Card = int.Parse(input);
                int player2Card = int.Parse(Console.ReadLine());
                if (player1Card > player2Card)
                {
                    player1Points += player1Card - player2Card;
                }
                else if (player2Card > player1Card)
                {
                    player2Points += player2Card - player1Card;
                }
                else
                {
                    numberWars = true;
                }
            }

            if (numberWars)
            {
                int player1Card = int.Parse(Console.ReadLine());
                int player2Card = int.Parse(Console.ReadLine());
                string winner;
                int winnerPoints = 0;
                if (player1Card > player2Card)
                {
                    winner = player1Name;
                    winnerPoints = player1Points;
                }
                else
                {
                    winner = player2Name;
                    winnerPoints = player2Points;
                }

                Console.WriteLine("Number wars!");
                Console.WriteLine($"{winner} is winner with {winnerPoints} points");
            }
            else
            {
                Console.WriteLine($"{player1Name} has {player1Points} points");
                Console.WriteLine($"{player2Name} has {player2Points} points");
            }
        }
    }
}
