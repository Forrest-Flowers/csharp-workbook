using System;
using System.Threading;
using System.Collections.Generic;

namespace dictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> grades = new Dictionary<string, int>();
            grades.Add("Jane", 75);
            grades.Add("Mark", 33);
            grades.Add("Mike", 45);
            grades.Add("June", 33);

            Console.WriteLine(grades ["June"]);

            foreach(string key in grades.Keys){
                int value = grades[key];
                Console.WriteLine("{0}'s grade is {1}.", key, value);
            }
        }
    }
}
