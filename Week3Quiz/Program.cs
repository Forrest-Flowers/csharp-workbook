using System;
using System.Collections.Generic;

namespace Week3Quiz
{
    class Program
    {
        static void Main(string[] args){
            // ARRAYS
        //     String[] names = new String[4];

        //     names[0] = "John";
        //     names[1] = "Mike";
        //     names[2] = "Adam";
        //     names[3] = "Jane";

        // String[] pets = {"Rocky", "Walter", "Bailey"};

        // String[] cities;
        // cities = new String[] {"Austin", "Dallas", "Houston"};

        // Console.WriteLine("Names {0}, {1}, {2}, {3}.", names);

        // int sizeOfArray = names.Length;
        // int lastIndex = sizeOfArray-1;
        // String lastName - names[lastIndex];

        // Console.WriteLine("In the array of size {0}, {1} is at index {2}.", sizeOfArray, lastIndex, lastName);

        List<String> names = new List<String>();
        names.Add("John");
        names.Add("Mike");
        names.Add("Mark");

        Console.WriteLine("This list has {0} elements", names.Count)
        }

    }
}
