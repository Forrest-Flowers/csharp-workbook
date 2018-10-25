using System;
using System.Threading;
using System.Collections.Generic;

namespace listPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            nameList.Add("Bob");
            nameList.Add("Horace");
            nameList.Add("Julio");
            nameList.Add("Kevin");
            nameList.Add("Stacey");

            foreach(string name in nameList){
                Console.WriteLine(name);
            }


        }
    }
}
