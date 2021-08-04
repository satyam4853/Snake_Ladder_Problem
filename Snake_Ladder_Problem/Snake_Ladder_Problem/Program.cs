using System;

namespace Snake_Ladder_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Snake and Ladder Problem");
            const int noplayoption = 0;
            const int ladderoption = 1;
            const int snakeoption = 2;
            int player = 0;
            int[] playerposition = new int[2] { 0, 0 };
            int diceRollCount = 0;
            while (playerposition[player] < 100)
            {
                Random random = new Random();
                int dieRoll = random.Next(1, 7);
                diceRollCount++;
                int options = random.Next(0, 3);
                switch (options)
                {
                    case noplayoption:
                        Console.WriteLine("Player " + player + "Position: " + playerposition[player]);
                        break;
                    case ladderoption:
                        if (playerposition[player] + dieRoll <= 100)
                        {
                            playerposition[player] = playerposition[player] + dieRoll;
                        }
                        Console.WriteLine("Player " + player + "Position: " + playerposition[player]);
                        break;
                    case snakeoption:
                        playerposition[player] = playerposition[player] - dieRoll;
                        if (playerposition[player] < 0)
                        {
                            playerposition[player] = 0;
                        }
                        Console.WriteLine("Player " + player + " Position: " + playerposition[player]);
                        break;
                }
                if (options == noplayoption || options == snakeoption)
                {
                    if (player == 0)
                    {
                        player = 1;
                    }
                    else
                    {
                        player = 0;
                    }
                }
            }
            Console.WriteLine("Player " + player + " Wins with Die Roll :" + diceRollCount);
        }
    }
}
