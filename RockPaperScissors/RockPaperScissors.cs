using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            if (tests())
            {
                Console.WriteLine("Tests Passed!");
            }
            else
            {
                Console.WriteLine("Tests Failed!");
            }
            Console.WriteLine("-----------------");

            string hand1 = null;


            while (hand1 == null)
            {
                try
                {
                    playerInput();
                }
                catch
                {
                    Console.WriteLine("Enter Rock Paper or Scissor. Come on, you know better than that.");
                }
            }
            
            string hand2 = computerInput();
            int compare = CompareHands(hand1, hand2);


            if (compare == 0)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (compare == 1)
            {
                Console.WriteLine("You Win, Congrats!");
            }
            else if (compare == 2)
            {
                Console.WriteLine("Computer Wins! Sorry bud.");
            }


            //Keep this here to keep code from closing out.
            Console.ReadLine();
        }

        //Get input from user and check if it's valid.
        public static string playerInput()
        {

            Console.WriteLine("Rock, Paper, Scissors!");
            string hand1 = Console.ReadLine().ToLower();

            if (hand1 != "rock" && hand1 != "paper" && hand1 != "scissors")
            {
                throw new Exception("Incorrect Input.");
            }
            else
            {
                return hand1;
            }

        }


        //Takes a random number and turns it into the computer's hand.
        public static string computerInput()
        {
            Random rps = new Random();
            int num = rps.Next(0, 3);
            string hand2;

            if (num == 0)
            {
                hand2 = "rock";
                Console.WriteLine("The computer chose rock!");
            }
            else if (num == 1)
            {
                hand2 = "paper";
                Console.WriteLine("The Computer chose paper!");
            }
            else if (num == 2)
            {
                hand2 = "scissors";
                Console.WriteLine("The computer chose scissors!");
            }
            else
            {
                throw new Exception("Error in computer generation.");
            }
            return hand2;
        }


        public static int CompareHands(string hand1, string hand2)
        {
            if (hand1 == hand2)
            {
                return 0;
            }
            else if (hand1 == "rock" && hand2 == "scissors" || hand1 == "paper" && hand2 == "rock" || hand1 == "scissors" && hand2 == "paper")
            {
                return 1;
            }
            else if (hand2 == "rock" && hand1 == "scissors" || hand2 == "paper" && hand1 == "rock" || hand2 == "scissors" && hand1 == "paper")
            {
                return 2;
            }
            else
            {
                throw new Exception("Comparison Error.");
            }
        }

        public static bool tests()
        {
            return
            CompareHands("rock", "rock") == 0 &&
            CompareHands("rock", "scissors") == 1 &&
            CompareHands("rock", "paper") == 2 &&

            CompareHands("paper", "paper") == 0 &&
            CompareHands("paper", "rock") == 1 &&
            CompareHands("paper", "scissors") == 2 &&

            CompareHands("scissors", "scissors") == 0 &&
            CompareHands("scissors", "paper") == 1 &&
            CompareHands("scissors", "rock") == 2;
        }
    }
}
