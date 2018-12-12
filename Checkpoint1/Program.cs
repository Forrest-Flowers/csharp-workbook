using System;
using System.Collections.Generic;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists how many divisible by 3 numbers there are between 1 and 100.
            Console.WriteLine("There are {0} numbers between 1 and 100 that are evenly divisible by 3", divideByThree());
            Console.WriteLine("----------------------------------------------------------------------");

            //Enter a number, get the factorial of that number.
            Console.WriteLine("Enter a number you want the factorial of:");
            Console.WriteLine(factorial());
            Console.WriteLine("------------------------------------------------------------------------");

            int secretNum = numGen();
            int chances = 4;
            Console.WriteLine("GUESS THE NUMBER:");


            //While you have chances left, you can keep on guessing the number.
            while (chances > 0)
            {
                Console.WriteLine("THE SECRET NUMBER IS " + secretNum);
                int guess = playerGuess();
                if (guess == secretNum)
                {
                    Console.WriteLine("Congrats, You Win!");
                    break;
                }
                else if (guess != secretNum)
                {
                    chances--;
                    Console.WriteLine("Wrong, you have {0} chance(s) left.", chances);
                }

                if (chances == 0)
                {
                    Console.WriteLine("You've run out of tries. Try again.");
                    break;
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Enter a number; enter 'ok' to add all previous numbers up! ");
            Console.WriteLine("The numbers you entered = " +addNumbers());

            Console.WriteLine("------------------------------------------------------------------------------");
            
            Console.WriteLine("Enter a series of numbers separated by a comma:");
            Console.WriteLine("The largest number you entered is: " + LargestNum());

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

        //Guess the number project.
        public static int numGen()
        {
            //Gets a random number
            Random rnd = new Random();
            int num = rnd.Next(1, 11);
            return num;
        }

        public static int playerGuess()
        {
            //Takes guess from player.
            int num1 = Convert.ToInt32(Console.ReadLine());
            return num1;
        }

        public static int addNumbers()
        {
            string userInput = Console.ReadLine();
            List<int> inputList = new List<int>();
            int sum = 0;

            if(userInput.ToLower() != "ok")
            {
                while (userInput.ToLower() != "ok")
                {
                    inputList.Add(Convert.ToInt32(userInput));
                    sum += Convert.ToInt32(userInput);

                    Console.WriteLine("Enter a number; enter 'ok' to add all previous numbers up! ");
                    userInput = Console.ReadLine();
                }
            }

            return sum;
        }

        public static int LargestNum()
        {
            string input = Console.ReadLine();

            string[] numArray = input.Split(",");

            int largestNum = Convert.ToInt32(numArray[0]);

            for(int i = 0; i < numArray.Length; i++)
            {
                if(largestNum < Convert.ToInt32(numArray[i]))
                {
                    largestNum = Convert.ToInt32(numArray[i]);
                }
            }

            return largestNum;
        }
    }
}