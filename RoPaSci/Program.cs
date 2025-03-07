using System;
using RoPaSci;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameItem item1 = Enum.Parse<GameItem>(args[0]);
            GameItem item2 = Enum.Parse<GameItem>(args[1]);

            int result = (int)RockPaperScissors(item1, item2);
            switch (result)
            {
                case 1:
                    Console.WriteLine("It's a draw!");
                    break;
                case 2:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 4:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, 
        GameItem player2)
        {
            GameStatus winnings = 0;
            if (player1 == player2)
            {
                winnings ^= GameStatus.Draw; // Draw
            }
            else if ((player1.HasFlag(GameItem.Rock) && player2.HasFlag
            (GameItem.Scissors)) || (player1.HasFlag(GameItem.Scissors) &&
            player2.HasFlag(GameItem.Paper)) || (player1.HasFlag(GameItem.Paper)
            && player2.HasFlag(GameItem.Rock)))    
            {
                winnings ^= GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                winnings ^= GameStatus.Player2Wins; // Player 2 wins
            }
            return winnings;
        }
    }
}
