using System;

namespace week1_practice
{
    class Program
    {
        static void Main(string[] args)
        {   // ints for add function.
            int num1;
            int num2;
            int total;

            // Write the first number in the problem
            Console.WriteLine("Please enter an integer you would like to add:");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Write the second number.
            Console.WriteLine("And the second integer:");
            num2 = Convert.ToInt32(Console.ReadLine());
            total = num1 + num2;

            //Let's add em up.

            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);

            //End of adding program.


            // The two ints we're working with.
            int yards = 1;
            int inches = yards * 36;

            // Converts yards to inches. Mission accomplished.
            Console.WriteLine("{0} yard(s) is equal to {1} inches.", yards, inches);

            bool People = true;
            var f = false;

            // Take var num and multiply it by itself.
            var num = 1.7m;
            Console.WriteLine(num * num);
            // Make var num an integer.
            int intnum = Convert.ToInt32(num);
            Console.WriteLine(intnum);

            //Personal Info
            string firstName = "Forrest";
            string lastName= "Flowers";
            string age = "19";
            string job = "Amateur Developer"; 
            string favoriteBand = "Streetlight Manifesto";
            // string favoriteSportsTeam = "N/A";

            //Writes out my amazing introduction.
            Console.WriteLine("Hi, my name is {0} {1} and I am {2} years old. I work as a {3}, and my favorite band is {4}.", firstName, lastName, age, job, favoriteBand);


            Console.WriteLine(100 * 10);
            Console.WriteLine(100 / 10);
            Console.WriteLine(100 + 10);
            Console.WriteLine(100 - 10);

        }   
    }
}
