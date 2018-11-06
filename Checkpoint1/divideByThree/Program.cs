using System;

namespace divideByThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisibleByThree = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    divisibleByThree++;
                }
            }
            Console.WriteLine("There are {0} numbers between 1 and 100 that are evenly divisible by 3", divisibleByThree);
        }
    }
}
