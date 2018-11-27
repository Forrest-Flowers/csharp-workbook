using System;

namespace enumPractice
{
    class Program
    {
         public enum PrimaryColors
        {
            Red, Blue, Yellow = 7
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string combined = combineColors(PrimaryColors.Red, PrimaryColors.Yellow);
            Console.WriteLine("Red + Yellow = "+combined);

            string combined2 = combineColors((PrimaryColors)0,(PrimaryColors)7);
            Console.WriteLine("Yellow and Red make: "+ combined2);
            Console.WriteLine((int)PrimaryColors.Red);
            Console.WriteLine((int)PrimaryColors.Blue);
            Console.WriteLine((int)PrimaryColors.Yellow);
        }

        public static string combineColors(PrimaryColors color1, PrimaryColors color2)
        {
            if (color1 == PrimaryColors.Red)
            {
                if (color2 == PrimaryColors.Yellow)
                {
                    return "ORANGE";
                }
                else if (color2 == PrimaryColors.Blue)
                {
                    return "PURPLE";
                }
                else if (color2 == PrimaryColors.Red)
                {
                    return "RED";
                }
            }
            else if (color1 == PrimaryColors.Blue)
            {
                if (color2 == PrimaryColors.Yellow)
                {
                    return "GREEN";
                }
                else if (color2 == PrimaryColors.Blue)
                {
                    return "BLUE";
                }
                else if (color2 == PrimaryColors.Red)
                {
                    return "PURPLE";
                }
            }

            else if (color1 == PrimaryColors.Yellow)
            {
                if (color2 == PrimaryColors.Yellow)
                {
                    return "YELLOW";
                }
                else if (color2 == PrimaryColors.Blue)
                {
                    return "GREEN";
                }
                else if (color2 == PrimaryColors.Red)
                {
                    return "ORANGE";
                }
            }

            return null;
        }
    }
}
