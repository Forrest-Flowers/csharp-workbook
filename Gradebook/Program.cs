using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare main variable
            Dictionary<String, String> gradeBook = new Dictionary<String, String>();
            Dictionary<String, int> gradeBookMax = new Dictionary<String, int>();
            Dictionary<String, int> gradeBookMin = new Dictionary<String, int>();
            Dictionary<String, decimal> gradeBookAvg = new Dictionary<String, decimal>();
            String yesNo = " ";
            //intro gradebook
            Console.WriteLine("Gradebook:");
            //this does the collecting of the data and interacting with user
            //try-catch for data entry errors
            try
            {
                dataEntry(gradeBook, yesNo);
            }
            catch (Exception)
            {
                if (yesNo != "Y" || yesNo != "N")
                {
                    Console.WriteLine("");
                    dataEntry(gradeBook, yesNo);
                }
            }
            finally
            {
                Console.WriteLine("STUDENTS:");
                foreach (KeyValuePair<String, String> student in gradeBook)
                {
                    Console.WriteLine($" Students: {student.Key} | Grades: {student.Value} ");
                }
                Console.WriteLine($"----------------------------------------------------");
            }

            maxGrade(gradeBook, gradeBookMax);
            Console.WriteLine("MAX GRADES:");
            foreach (KeyValuePair<String, int> student1 in gradeBookMax)
            {
                Console.WriteLine($" Students: {student1.Key} | Max Grade: {student1.Value} ");
            }
            Console.WriteLine("---------------------------------------------------------");

            minGrade(gradeBook, gradeBookMin);
            Console.WriteLine("MIN GRADES:");
            foreach (KeyValuePair<String, int> student2 in gradeBookMin)
            {
                Console.WriteLine($" Students: {student2.Key} | Min Grade: {student2.Value} ");
            }
            Console.WriteLine("----------------------------------------------------------");

            avgGrade(gradeBook, gradeBookAvg);
            Console.WriteLine("AVERAGE GRADES:");
            foreach (KeyValuePair<String, decimal> student3 in gradeBookAvg)
            {
                Console.WriteLine($" Students: {student3.Key} | Min Grade: {student3.Value} ");
            }
            Console.WriteLine("-----------------------------------------------------------");
        }

        public static Dictionary<String, String> dataEntry(Dictionary<String, String> gradeBook, String yesNo)
        {
            //declare variables
            String studentName = " "; //key
            String studentGrades = " "; //value

            //while conditionals are true the app continues to get data
            while (true)
        
                //if the user does not enter yes or no, they try again.
                Console.WriteLine("Select Y to enter data, N to return calculations.");
                yesNo = Console.ReadLine().ToLower();
                if (yesNo == "y" || yesNo == "yes")
                {
                    Console.WriteLine("Enter students name in format 'last name , first name'.");
                    studentName = (Console.ReadLine().ToLower());

                    Console.WriteLine($"Enter grades for {studentName}.\nEach grade must be seperated by a comma.\nExample: (88,95)");
                    studentGrades = Console.ReadLine();

                    gradeBook.Add(studentName, studentGrades);
                }
                else if (yesNo == "n" || yesNo == "no")
                {
                    break;

                }
                else
                {
                    throw new Exception("Yes or No answers only.");
                }
            }
            return gradeBook;
        }
        public static Dictionary<String, int> maxGrade(Dictionary<String, String> gradeBook, Dictionary<String, int> gradeBookMax)
        {
            foreach (KeyValuePair<String, String> student in gradeBook)
            {
                var studentMax = student.Key;
                string[] splitMax = student.Value.Split(',');
                //assumes 1st entry could be largest
                int max1 = Convert.ToInt32(splitMax[0]);
                //compares all entries in string []
                foreach (var maxCheck in splitMax)
                {
                    int splitMaxGrade = Convert.ToInt32(maxCheck);
                    if (splitMaxGrade > max1)
                    {
                        max1 = splitMaxGrade;
                    }
                }
                gradeBookMax.Add(studentMax, max1);
            }
            return gradeBookMax;
        }
        public static Dictionary<String, int> minGrade(Dictionary<String, String> gradeBook, Dictionary<String, int> gradeBookMin)
        {
            foreach (KeyValuePair<String, String> student in gradeBook)
            {
                var studentMin = student.Key;
                string[] splitMin = student.Value.Split(',');

                int min1 = Convert.ToInt32(splitMin[0]);

                foreach (var minCheck in splitMin)
                {
                    int splitMinGrade = Convert.ToInt32(minCheck);
                    if (splitMinGrade < min1)
                    {
                        min1 = splitMinGrade;
                    }
                }
                gradeBookMin.Add(studentMin, min1);
            }
            return gradeBookMin;
        }
        public static Dictionary<String, decimal> avgGrade(Dictionary<String, String> gradeBook, Dictionary<String, decimal> gradeBookAvg)
        {
            foreach (KeyValuePair<String, String> student in gradeBook)
            {
                var studentWAvg = student.Key;
                String[] studentAvgSplit = student.Value.Split(',');
                decimal[] studentAvg = studentAvgSplit.Select(x => Convert.ToDecimal(x)).ToArray();
                decimal avg1 = studentAvg.Average();
                gradeBookAvg.Add(studentWAvg, avg1);
            }
            return gradeBookAvg;
        }
    }
}