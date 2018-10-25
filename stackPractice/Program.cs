using System;
using System.Threading;
using System.Collections.Generic;

namespace stackPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Jack");
            names.Push("Jane");
            names.Push("Mike");
            names.Push("Martha");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }



            while (names.Count > 0)
            {
                string currentName = names.Pop();
                Console.WriteLine("Processing... " + currentName);
                try
                {
                    string nextName = names.Peek();
                    Console.WriteLine("Next in Line: " + nextName);
                }
                catch
                {
                    Console.WriteLine("I can't see who's next, the stack is probably empty.");
                }
                Console.WriteLine("----------------------------");

            }

            Console.WriteLine("Stack size: " + names.Count);
        }
    }
}
