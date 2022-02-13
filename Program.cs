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

            int rollyTry = 0;

            DiceRolling diceRolling = new DiceRolling();
            UserInfo user = new UserInfo();


            while (user.UserPosition < 100)
            {

                //variables
                int diceNumber = diceRolling.diceRoll();
                int functionNumber = diceRolling.Function();
                //Console.WriteLine(diceNumber)

                switch (functionNumber)
                {
                    case LADDER:
                        //user .UserPosition= user .UserPosition + dicenumber <= 100? user .Userposition: user .userPosition + diceNumber; 
                        if (user.UserPosition += diceNumber) ;
                        {
                            user.UserPosition -= diceNumber;
                        }
                        break;
                    case SNAKE:
                        if (user.UserPosition += diceNumber) ;
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
                rollyTry++;
                Console.WriteLine($"position; {user.UserPosition}");
                Console.WriteLine($"on. of try: {rollyTry}");

            }
        }

    }
}


       