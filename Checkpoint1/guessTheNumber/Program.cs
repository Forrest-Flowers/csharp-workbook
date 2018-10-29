using System;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 11);
            int chances = 4;
            int guess = playerGuess();

            Console.WriteLine("--- The secret number is {0} ---", num);
            Console.WriteLine("GUESS THE NUMBER:");

            while (chances > 0)
            {
                if (guess == num)
                {
                    Console.WriteLine("Congrats, You Win!");
                    return;
                }
                else if (guess != num)
                {
                    chances--;
                    Console.WriteLine("Wrong, you have {0} chance(s) left.", chances);

                    if (chances == 0)
                    {
                        Console.WriteLine("You've run out of guesses, You lost!");
                        return;
                    }
                    else
                    {
                        playerGuess();
                    }
                }

            }
        }

        public static int playerGuess()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            return num1;
        }
    }
}