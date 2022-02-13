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
            int turnNumber = 0;

            DiceRolling diceRolling = new DiceRolling();
            UserInfo user1 = new UserInfo();
            UserInfo user2 = new UserInfo();


            while (diceRolling.gameEnd == false)
            {

                //variables
                int diceNumber = diceRolling.diceRoll();
                int functionNumber = diceRolling.Function();
                //Console.WriteLine(diceNumber);
                switch (functionNumber)
                {
                    case LADDER:
                        //user .UserPosition= user .UserPosition + dicenumber <= 100? user .Userposition: user .userPosition + diceNumber; 
                        if (turnNumber == 1 && user1.UserPosition + diceNumber <= 100)
                        {
                            user2.UserPosition += diceNumber;
                        }
                        else
                        {
                            Console.WhiteLine("max limit 100");
                        }

                        break;
                    case SNAKE:
                        if (turnNumber == 1 && user1.UserPosition > diceNumber)
                        {
                            user1.UserPosition -= diceNumber;
                        }
                        else (turnNumber == 2 && user2.UserPosition < diceNumber)
                        {
                            user2.UserPosition -= diceNumber;
                        }
                        else
                        {
                            Console.WriteLine("nagative");
                        }
                        turnNumber = diceNumber.UserTurn(turnNumber);
                        break;
                       
                    case NO_PLAY:
                        Console.WriteLine("on play");
                        turnNumber = diceRolling.UserTurn(turnNumber);
                        break;
                    default:
                        Console.WriteLine("defult case error");
                        break;

                }
                rollyTry++;
                Console.WriteLine($"position; {user1.UserPosition} 2: {user2.UserPosition}");
                Console.WriteLine($"on. of try: {rollyTry}");

            }
        }

    }
}


       