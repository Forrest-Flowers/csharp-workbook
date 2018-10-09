using System;

namespace week1_practice
{
    class Program
    {
        static void Main(string[] args)
        {   int num1;
            int num2;
            int total;

            Console.WriteLine("Please enter an integer you would like to add:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And the second integer:");
            num2 = Convert.ToInt32(Console.ReadLine());
            total = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);

            string name = "John";

            name.ToUpper();
            Console.WriteLine(name.ToUpper());

            bool People = true;
            var f = false;
            var num = 1.7;
            Console.WriteLine(num * num);

            // string firstName = "Forrest";
            // string lastName= "Flowers";
            // string age = "19";
            // string job = "Amateur Developer"; 
            // string favoriteBand = "Streetlight Manifesto";
            // string favoriteSportsTeam = "N/A";
        }   
    }
}
