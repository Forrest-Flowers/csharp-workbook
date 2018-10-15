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
            String ch2;
            String ch3;
            bool stick = false;

            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you pick up the stick? [y/n]");
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

            Console.WriteLine("As you proceed further into the cave, you see a small glowing object");
            Console.WriteLine("Do you approach the object? [y/n]");
            ch2 = Console.ReadLine();

            //FIGHT OR FLIGHT
            if(ch2 == "y" || ch2 == "Y" || ch2 == "Yes" || ch2 == "YES" || ch2 == "yes"){
                Console.WriteLine("You approach the object...");
                Thread.Sleep(2000);
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Thread.Sleep(1000);
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you try to fight it? [Y/N]");
                ch3 = Console.ReadLine();

            //FIGHT SPIDER
            if(ch3 == "y" || ch3 == "Y" || ch3 == "Yes" || ch3 == "YES" || ch3 == "yes"){

            //HAS A STICK
            if(stick == true){
                Console.WriteLine("You only have a stick to fight with!");
                Console.WriteLine("You quickly jab the spider in it's eye to gain an advantage.");
                Thread.Sleep(2000);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("                  Fighting...                   ");
                Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                int fdmg1;
                int edmg1;
                Random dmg = new Random();


                fdmg1 = dmg.Next(3, 11);
                Console.WriteLine("You hit for {0} damage!", fdmg1);

                edmg1 = dmg.Next(1,6);
                Console.WriteLine("The spider hits for {0} damage!", edmg1);
                Console.ReadLine();
            
            if(edmg1 > fdmg1){
                Console.WriteLine("The spider has done more damage than you!");
                return;
            }else if(fdmg1 < 5){
                Console.WriteLine("You don't do enough damage to kill the spider, but you manage to wound it!");

                return;
            }else if(fdmg1 > 5){
                Console.WriteLine("You killed the spider!");

                return;
            }

            }// NOSTICK
            else{
                Console.WriteLine("You don't have anything to fight with!");
                Thread.Sleep(2000);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("                  Fighting...                   ");
                Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                int fdmg0;
                int edmg0;
                Random dmg = new Random();

                fdmg0 = dmg.Next(1, 9);
                Console.WriteLine("You hit for {0} damage!", fdmg0);

                edmg0 = dmg.Next(1,6);
                Console.WriteLine("The spider hits for {0} damage!", edmg0);
                Console.ReadLine();
                if(edmg0 > fdmg0){
                Console.WriteLine("The spider has done more damage than you!");
                return;

            }else if(fdmg0 < 5){
                Console.WriteLine("You don't do enough damage to kill the spider, but you manage to wound it!");
                return;
            }else if(fdmg0 > 5){
                Console.WriteLine("You killed the spider!");
                return;
            }

            }//END NOSTICK FIGHT

            }//END FIGHT SPIDER
             else{
                 Console.WriteLine("You choose not to fight the spider.");
                 Thread.Sleep(1000);
                 Console.WriteLine("As you turn away, it ambushes you and impales you with it's fangs!!!");
                 return;
             }

            }//END FIGHT OR FLIGHT
             else{
                 Console.WriteLine("You turn away from the glowing object, and attempt to leave the cave...");
                 Thread.Sleep(1000);
                 Console.WriteLine("But something won't let you....");
                 return;
             }

        }
    }
}

