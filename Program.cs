// See https://aka.ms/new-console-template for more information
using System;

namespace SnakeLadderProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("snake ladder game");
            GamePlay();
        }

        public static void GamePlay()
        {
            //constants
            const int LADDER = 1;
            const int SNAKE = 2;
            const int NO_PLAY = 3;

            DiceRolling diceRolling = new DiceRolling();
            UserInfo user = new UserInfo();


            //variables
            int diceNumber = diceRolling.diceRoll();
            int functionNumber = diceRolling.Function();
            //Console.WriteLine(diceNumber)
            while (user.UserPosition < 100)
            {

                switch (functionNumber)
            {
                case LADDER:
                    user.UserPosition += diceNumber;
                    break;
                case SNAKE:
                  if  (user.UserPosition += diceNumber);
                   {
                       user.UserPosition -= diceNumber;
                   }
                   else
                   {
                        user.UserPosition = 0;
                        Console.WriteLine("user position nagative");

                        }
                    break;
                case NO_PLAY:
                    Console.WriteLine("on play");
                    break;
                default:
                    Console.WriteLine("defult case error");
                    break;

            }
            Console.WriteLine(user.UserPosition);
        }

    }
}


       