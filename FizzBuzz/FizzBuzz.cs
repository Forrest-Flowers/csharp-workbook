using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= num; i++)
            {
                //Couple of Variables.
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                //If both fizz and buzz, write "FizzBuzz"
                //If just fizz, write "Fizz"
                //If just buzz, write "Buzz"
                //Else, write the number.
                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }



        }
    }
}
