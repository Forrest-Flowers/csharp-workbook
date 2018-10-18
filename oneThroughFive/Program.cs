using System;

namespace oneThroughFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 0; i < 6; i++){
                sum+= i;
            }

            Console.WriteLine("It equals {0}", sum);
        }
    }
}
