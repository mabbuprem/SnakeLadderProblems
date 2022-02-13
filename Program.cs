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
            //Constants
            const int LADDER = 1;
            const int SNAKE = 2;
            const int NO_PLAY = 3;

            int rollTry = 0;
            int turnNumber = 0;

            DiceRolling diceRolling = new DiceRolling();
            UserInfo user1 = new UserInfo Info();
            UserInfo user2 = new UserInfo Info();


            while (diceRolling.gameEnd == false)
            {
                //variables
                int diceNumber = diceRolling.diceRoll();
                int functionNumber = diceRolling.Function();
                //Console.WriteLine(diceNumber)
                switch (functionNumber)
                {
                    case LADDER:
                        //user .UserPosition= user .UserPosition + dicenumber <= 100? user .Userposition: user .userPosition + diceNumber;
                        if (turnNumber == 1 && user1.userPosition + diceRolling <= 100)
                        {
                            user1.UserPosition += diceNumber;
                        }
                        else if (turnNumber == 2 && user2.UserPosition + diceRolling <= 100)
                        {
                            user2.UserPosition += diceNumber;
                        }
                        else
                        {
                            Console.WriteLine("max limit 100");
                        }

                        break;
                    case SNAKE:
                        //user .UserPosition= user .UserPosition + dicenumber <= 100? user .Userposition: user .userPosition + diceNumber;
                        if (turnNumber == 1 && user1.userPosition + diceRolling <= 100)
                        {
                            user1.UserPosition += diceNumber;
                        }
                        else if (turnNumber == 2 && user2.UserPosition + diceRolling <= 100)
                        {
                            user2.UserPosition += diceNumber;
                        }
                        else
                        {
                            Console.WriteLine("negative");
                        }
                        turnNumber == diceRolling.UserTurn(turnNumber);
                        break;
                    case NO_PLAY:
                        Console.WriteLine("no play");
                        turnNumber = diceRolling.UserTurn(turnNumber);
                        break;
                    default:
                        Console.WriteLine("defult case error");
                        break;
                }
                if (user1.UserPosition >= 100 || user2.UserPosition >= 100)
                {
                    diceRolling.gameEnd = true;
                }
                rollTry++;
                Console.WriteLine($"position 1: {user1.UserPosition} 2: {user2.UserPotion}");
                Console.WriteLine($"no. of try: {rollTry}");

            }
        }
    }
}

                