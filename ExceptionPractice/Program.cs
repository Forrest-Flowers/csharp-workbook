using System;

namespace ExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            double ans1 = divide(17.0, 0.0);
            Console.WriteLine(ans1);
            }
            catch
            {
            Console.WriteLine("Oops, there was a problem with the divide function.");
            }
            
        }
        public static double divide(double num1, double num2)
        {
            if (num2 == 0.0)
            {
                throw new Exception("Cannot divide by 0, Sorry!");
            }
            return num1 / num2;
        }
    }
}
