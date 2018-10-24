using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            string hand1 = playerInput();
            string hand2 = computerInput();

            

            CompareHands(hand1, hand2);




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
            return hand1;
        }


        //Takes a random number and turns it into a game choice.
        public static string computerInput()
        {
            Random rps = new Random();
            int num = rps.Next(0, 3);
            string hand2;

            Console.WriteLine(num);

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
    }
}
