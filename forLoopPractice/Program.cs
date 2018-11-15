using System;

namespace forLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 9, 13, 4, 12, 3 };
            int max = forLoop(myArray);

            Console.WriteLine(max);
        }

        static int forLoop(int[] myArray)
        {
            int max = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (max < myArray[i])
                {
                    max = myArray[i];
                }
            }

            return max;
        }
        static int forEachLoop(int[] myArray)
        {
            int max = myArray[0];

            foreach (int currentNum in myArray)
            {
                if (max < currentNum)
                {
                    max = currentNum;
                }
            }

            return max;

        }
    }
}