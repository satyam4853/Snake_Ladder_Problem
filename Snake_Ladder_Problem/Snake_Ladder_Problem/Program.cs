using System;

namespace Snake_Ladder_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is snake and ladder problem");
            int PlayerOne = 1;
            int PlayerPosition = 0;
            Random random = new Random();
            int RollDie = random.Next(1, 7);
            Console.WriteLine("Die is Rolls : " + RollDie);
        }
    }
}
