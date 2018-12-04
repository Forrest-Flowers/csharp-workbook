using System;
using System.IO;

namespace filePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            String file = @"test.txt";

          string[] lines = File.ReadAllLines(file);

            int lineNo = 0;
          foreach(String line in lines)
          {
              lineNo += 1;
              Console.WriteLine(lineNo+" "+line);
          }
        
        string copy = @"copy.txt";
        File.WriteAllLines(copy, lines);

        }
    }
}
