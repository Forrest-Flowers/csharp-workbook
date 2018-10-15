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
            


            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you pick up the stick? [y/n]");
            ch1 = Console.ReadLine();
            // STICK TAKEN
            if (ch1 == "y" || ch1 == "Y" || ch1 == "Yes" || ch1 == "YES" || ch1 == "yes"){
                Console.WriteLine("You pick up the stick!");
                Thread.Sleep(2000);
                bool stick = true;
            }//STICK NOT TAKEN
            else{
                Console.WriteLine("You pass up the Stick.");
                Thread.Sleep(2000);
                bool stick = false;
            }
            string ch2;

            Console.WriteLine("As you proceed further into the cave, you see a small glowing object");
            Console.WriteLine("Do you approach the object? [y/n]");
            ch2 = Console.ReadLine();

            if(ch2 == "y" || ch2 == "Y" || ch2 == "Yes" || ch2 == "YES" || ch2 == "yes"){
                string ch3;
                
                Console.WriteLine("You approach the object...");
                Thread.Sleep(2000);
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Thread.Sleep(2000);
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you try to fight it? [Y/N]");





            }else
            

        }
    }
}
