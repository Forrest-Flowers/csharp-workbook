using System;
using System.Threading;

namespace textGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(2000);

            String ch1;
            bool stick = false;

            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you pick up the stick? (y/n)");
            ch1 = Console.ReadLine();
            // STICK TAKEN
            if (ch1 == "y" || ch1 == "Y" || ch1 == "Yes" || ch1 == "YES" || ch1 == "yes"){
                Console.WriteLine("You pick up the stick!");
                Thread.Sleep(2000);
                stick = true;
            }//STICK NOT TAKEN
            else{
                Console.WriteLine("You pass up the Stick.");
                Thread.Sleep(2000);
                stick = false;
            }

        }
    }
}
