using System;

namespace week2Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for grade
            //if number is a grade, print out you made an A
            int grade = 0;
            string input;

            Console.WriteLine("Enter a Numerical Grade:");
            input = Console.ReadLine();
            grade = Convert.ToInt32(input);

            if(grade >= 90){
                Console.WriteLine("You made an A! Congrats!");
            }else if(grade >= 80){
                Console.WriteLine("You made a B! Almost Perfect.");
            }else if(grade >= 70){
                Console.WriteLine("You made a C! Study up.");
            }else if(grade >= 60){
                Console.WriteLine("You made a D! You can do better.");
            }else{
                Console.WriteLine("You Failed! Try again!");
            }         
            Console.WriteLine("Thank you for submitting.");
        }
    }
}
