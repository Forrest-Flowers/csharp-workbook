using System;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random randomGen = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomGen.Next(0, 100000);
            }

            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }

            var justEvens = from n in numbers
                where (n % 2) == 0
                select n;

            foreach(int n in justEvens)
            {
                Console.WriteLine(n);
            }

            // for every n in numbers, I want n where(n%2 is equal to 0)
        }
    }
}
