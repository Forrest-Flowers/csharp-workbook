using System;

namespace factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = num;

            for (int i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }

            Console.WriteLine("{0}! = {1}", num, fact);
        }
    }
}
