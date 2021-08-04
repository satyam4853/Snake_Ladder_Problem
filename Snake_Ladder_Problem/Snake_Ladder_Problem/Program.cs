using System;

namespace Snake_Ladder_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Snake and Ladder Problem");
            const int PlayerOne = 1;
            const int PlayerPosition = 0;
            const int noplayoption = 0;
            const int ladderoption = 1;
            const int snakeoption = 2;
            int positionone = 0;
            int diceRollCount = 0;
            while (positionone < 100)
            {
                Random random = new Random();
                int dieRoll = random.Next(1, 7);
                diceRollCount++;
                int options = random.Next(0, 3);
                Console.WriteLine("Position: " + positionone);
                switch (options)
                {
                    case noplayoption:
                        Console.WriteLine("Position: " + positionone);
                        break;
                    case ladderoption:
                        if (positionone + dieRoll <= 100)
                        {
                            positionone = positionone + dieRoll;
                        }
                        Console.WriteLine("Position: " + positionone);
                        break;
                    case snakeoption:
                        positionone = positionone - dieRoll;
                        if (positionone < 0)
                        {
                            positionone = 0;
                        }
                        Console.WriteLine("Position: " + positionone);
                        break;
                }
            }
            Console.WriteLine("Player Wins With Position : " + diceRollCount);
        }
    }
}
