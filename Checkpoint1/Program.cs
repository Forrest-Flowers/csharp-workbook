using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are {0} numbers between 1 and 100 that are evenly divisible by 3", divideByThree());
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("Enter a number you want the factorial of:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = factorial();
            Console.WriteLine("{0} != {1}", num, fact);
        }

        public static int divideByThree()
        {
            int divisibleByThree = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    divisibleByThree++;
                }
            }
            return divisibleByThree;
        }

        public static int factorial(int num)
        {
            int fact = num;

           //int i, num and fact. Start i at 1 less than input and go down to 1 then multiply those numbers together to find fact.
           for (int i = num - 1; i >= 1; i--)
           {
               fact = fact * i;
           }
            return fact;
        }
    }
}
