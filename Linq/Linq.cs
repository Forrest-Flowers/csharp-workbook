using System;
using System.Linq;
using System.Collections.Generic;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List <Student>();

            for (int i = 0; i < 10; i++)
            {
                studentList.Add(Student.generateRandom());
            }
            Console.WriteLine("All the students:");
            foreach(var s in studentList)
            {
                Console.WriteLine(s);
            }

            IEnumerable<Student> negativeBalance = from s in studentList
            where s.tuition < 0
            select s;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Students with negative balance:");
            foreach(Student s in negativeBalance)
            {
                Console.WriteLine(s);
            }
        }
    }

    public class Student
    {
        public string name;
        public int tuition;
        static Random randomGen = new Random();

        override
        public string ToString()
        {
            return name + ", tuition: " + tuition;
        }

        public static Student generateRandom()
        {
            string randomName = "";
            int randomNameSize = randomGen.Next(10, 20);
            for (int i = 0; i < randomNameSize; i++)
            {
                char randomLetter = (char)('A' + randomGen.Next(0, 26));
                randomName += randomLetter;
            }

            int randomTuition = randomGen.Next(-5000, 5000);
            Student randomStudent = new Student();
            randomStudent.name = randomName;
            randomStudent.tuition = randomTuition;
            return randomStudent;

        }
    }
}
