using System;

namespace Snake_Ladder_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Snake and Ladder Problem");
            int PlayerOne = 1;
            int PlayerPosition = 0;
            const int noplayoption = 0;
            const int ladderoption = 1;
            const int snakeoption = 2;
            int positionone = 0;
            Random random = new Random();
            int RollDie = random.Next(1, 7);
            Console.WriteLine("Die is Rolls : " + RollDie);
            int options = random.Next(0, 3);
            switch (options)
            {
                case noplayoption:
                    positionone = positionone + 0;
                    break;
                case ladderoption:
                    positionone = positionone + RollDie;
                    break;
                case snakeoption:
                    positionone = positionone - RollDie;
                    if (positionone < 0)
                    {
                        positionone = 0;
                    }
                    break;
            }
        }
    }
}
