using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> inventory = new List<Vehicle>();

            bool done = false;

            while (!done)
            {
                // ask the user for what they want to do
                String option = getUserOption();

                // if they want to list the inventory
                // call the method to list it
                if (option == "list")
                {
                    printInventory(inventory);
                }
                // if they want to add an item to the inventory, 
                // call the method to get the item from the user
                else if (option == "add")
                {
                    String newItem = getNewItem();
                    inventory.Add(newItem);
                }
                // if they want to delete an item,
                // call a method to get the index of the item they want to delete
                else if (option == "delete")
                {
                    int idx = getDeletePosition();
                    if (idx >= 0 && idx < inventory.Count)
                    {
                        inventory.RemoveAt(idx);
                    }
                    else
                    {
                        Console.WriteLine("Bad position");
                    }
                }
                // if they want to quit,
                // set the done flag to false, so the main loop exits
                else if (option == "quit")
                {
                    done = true;
                }

                // print an empty line just to break up the input
                // Console.clear would also work here
                Console.WriteLine();
            }

        }


        // this method ask the user for a position they want to delete.
        // and returns it. if thy enter an non integer value, we return -1
        public static int getDeletePosition()
        {
            // ask the user for a position.
            Console.Write("Choose an item to delete by entering its number: ");
            String input = Console.ReadLine();
            try
            {
                // try to convert their input to an int
                // we subtract 1 from their input because the index in the list starts at 0
                // but we displayed the list with numbers starting at 1.
                return Convert.ToInt32(input) - 1;
            }
            catch
            {
                // reutrn -1 if we could not convert their input to an int
                return -1;
            }

        }

        // this method ask the user for the item they want to add to the inventory
        // and return their input
        public static Vehicle getNewItem()
        {
            // ask for an item, and return the input
            Console.Write("Enter a color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter a make:");
            string make = Console.ReadLine();
            Console.WriteLine("Enter a model:");
            string model = Console.ReadLine();


        }

        // ask the user for a valid  input and reutrn it
        // we do not valid that option
        public static String getUserOption()
        {
            Console.Write("Choose a command (list, add, delete) ");
            return Console.ReadLine();
        }

        // print the inventory out to the console.
        public static void printInventory(List<String> inventory)
        {

            // if the inventory is empty, we print a message letting them know that
            // and exit the function
            if (inventory.Count == 0)
            {
                Console.WriteLine("You dont have any inventory");
                return;
            }

            // we start at position 1, so the inventory has nice numbers
            // we should remeber that the user sees the numbers starting as 1,
            // so when asking for item to delete, we need to automatically
            // handle that the index into the list starts at 0.
            int index = 1;
            // loop through the inventory and print it to the console
            foreach (String item in inventory)
            {
                Console.WriteLine("{0} - {1}", index, item);
                index++;
            }
        }


    }

    abstract class Vehicle
    {
        public string color;
        public string make;
        public string model;
        public int numberOfWheels;

        Vehicle(string color, string make, string model)
        {
            this.color = color;
            this.make = make;
            this.model = model;
            this.numberOfWheels;
        }

        override    
        public string toString()
        {
            string formatted = String.Format("{0} {1} {2}", color, make, model);
            return formatted;
        }
    }

    public class Car: Vehicle
    {
        bool isHatchback;
        public Car(string color, string make, string model, bool isHatchback): base(color, make, model, 4)
        {
            this.isHatchback = isHatchback;
        }
    }
}