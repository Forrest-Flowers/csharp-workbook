using System;

namespace factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get User Input.
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = num;

            //int i, num and fact. Start i at 1 less than input and go down to 1 then multiply those numbers together to find fact.
            for (int i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }

            Console.WriteLine("{0}! = {1}", num, fact);
        }
    }
}
