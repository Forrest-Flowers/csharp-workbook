using System;
using System.Collections.Generic;

namespace maxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of numbers, seperated by a comma:");
            int input = userInput();
            List<int> list = new List<int> { };

            list.Add(input);

            foreach(int item in list)
            {
                Console.WriteLine();
            }

        }

        public static int userInput()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    }
}
