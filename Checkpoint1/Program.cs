using System;
using System.Collections.Generic;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("There are {0} numbers between 1 and 100 that are evenly divisible by 3", divideByThree());
            // Console.WriteLine("----------------------------------------------------------------------");

            // Console.WriteLine("Enter a number you want the factorial of:");
            // Console.WriteLine(factorial());
            // Console.WriteLine("------------------------------------------------------------------------");

            // int secretNum = numGen();
            // int chances = 4;

            // Console.WriteLine("--- The secret number is {0} ---", secretNum);
            // Console.WriteLine("GUESS THE NUMBER:");

            // int guess = playerGuess();
            // while (chances > 0)
            // {
            //     if (guess == secretNum)
            //     {
            //         Console.WriteLine("Congrats, You Win!");
            //         break;
            //     }

            //     else if (guess != secretNum)
            //     {
            //         chances--;
            //         Console.WriteLine("Wrong, you have {0} chance(s) left.", chances);
            //         playerGuess();
            //     }
            //     if (chances == 0)
            //     {
            //         Console.WriteLine("You've run out of tries. Try again.");
            //         break;
            //     }

            // }
            // Console.WriteLine("----------------------------------------------------------------------------");


            // Console.WriteLine("Please enter a number. Enter 'OK' to add all previously entered numbers.");
            // string userInput = AddInput();
            // int sum = 0;
            // while (userInput != "ok")
            // {
            //     sum = Convert.ToInt32(userInput) + sum;
                
            //     userInput;

            // }
            // Console.WriteLine(sum);
            // Console.WriteLine("----------------------------------------------------------------------------------------");

            
            Console.WriteLine("Enter in 5 numbers separated with a comma.");
            string input = 

            
    



            findMaxInArray();

        }

        //Divide By Three project (Number 1 on list):
        public static int divideByThree()
        {
            int divisibleByThree = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    divisibleByThree++;
                }
            }
            return divisibleByThree;
        }
        //Factorials project (Number 3 on list):
        public static string factorial()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = num;

            //int i, num and fact. Start i at 1 less than input and go down to 1 then multiply those numbers together to find fact.
            for (int i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }

            string equation = $"{num} != {fact}";

            return equation;
        }

        public static int numGen()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 11);
            return num;
        }


        public static int playerGuess()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            return num1;
        }
        //Add Numbers Project (Number 2 on List.):
        public static string AddInput()
        {
            string userInput = Console.ReadLine().ToLower();
            return userInput;
        }

        // Max Array Project (Number 5 on List.):

        public static string intialInput()
        {   
           string input = Console.ReadLine();
            return input;
        }

        public static int findMaxInArray()
        {

        }


    }



}


