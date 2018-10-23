using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Rock, Paper, Scissors!");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("The Computer is thinking...");
            string hand2 = ""
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static string checkInput(string hand1)
        {  
            if (hand1 != "rock" && hand1 != "paper" && hand1 != "scissors")
            {
                throw new Exception("Incorrect Input.");
            }
            return hand1;
        }

        public static void computerInput(string hand2){
            Random rps = new Random();

            rps(0,3);
        }

        //returns 1 if hand1 wins
        //returns 2 if hand2 wins
        //returns 0 if tie.
        public static string CompareHands(string hand1, string hand2)
        {
            if (hand1 == hand2)
            {
                
            }
            else if (hand1 == "rock" && hand2 == "scissors" || hand1 == "paper" && hand2 == "rock" || hand1 == "scissors" && hand2 == "paper")
            {

            }
            else if (hand2 == "rock" && hand1 == "scissors" || hand2 == "paper" && hand1 == "rock" || hand2 == "scissors" && hand1 == "paper")
            {

            }
            else
            {

            }
        }

        //returns true if all tests pass
        //returns false if 1 or more fails
        public static bool tests(string hand1, string hand2)
        {
            // return
            // CompareHands("Rock","Paper") == 2 &&
            // CompareHands("Rock","Scissors") == 1 &&
            // CompareHands("Rock","Rock") == 0 &&
            // CompareHands("Paper","Scissors") == 2 &&
            // CompareHands("Paper","Rock") == 1 &&
            // CompareHands("Paper","Paper") == 0 &&
            // CompareHands("Scissors","Rock") == 2 &&
            // CompareHands("Scissors","Paper") == 1 &&
            // CompareHands("Scissors","Scissors") == 0;



        }
    }
}
