using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please fill out the form.");
            Form();
        }
        static void Form()
        {
            string name = "";
            int age = 0;
            int year = 0;
            string food = "";
            string color = "";

            Console.WriteLine("Please Enter your Name:");
		    name = Console.ReadLine();
            Console.WriteLine("Please Enter your Age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Current Year:");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your favorite food?");
            food = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            color = Console.ReadLine();

            Console.WriteLine("Hello! My name is {0} and I am {1} years old. I was born in {2}. My favorite food is {3} and my favorite color is {4}.", name, age, year-age, food, color);


        }
    }
}
