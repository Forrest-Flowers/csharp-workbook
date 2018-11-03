using System;
using System.Collections.Generic;

namespace week5Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Mike", "Doe");

            p1.YOB = 1973;
            p1.gender = 'M';
            p1.hairColor = "brown";

            Person.counter = 1;

            Person p2 = new Person("John", "Smith");

            p2.YOB = 2010;
            p2.gender = 'M';
            p2.hairColor = "red";


            Console.WriteLine("p1's full name is {0}", p1.fullName());
            Console.WriteLine("p2's full name is {0}", p2.fullName());

            Console.WriteLine(Person.genericHello());
            Console.WriteLine(Person.hello());

            Console.WriteLine("I have created {0} Person instances.", Person.counter);
        }
    }

    // class Company
    // {
    //     String name;
    //     List<Person> employees;
    // }

    class Person
    {
        //public get means any class can view.
        //private set means you can't set it outside this class.
        public string firstName {get; private set;}
        public string lastName;
        public int YOB;
        public char gender;
        public string hairColor;

        public static int counter = 0;

        //Constructor; Same name as class.
        public Person(string firstName, string lastName)
        {
            //Any code you want, when you make a new instance of the class.
            counter += 1;
            if (firstName == null || lastName == null)
            {
                throw new Exception("Everyone must have a first and last name.");
            }

            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(){
            counter +=1;
            firstName = "John";
            lastName = "Doe";
        }

        public string fullName()
        {
            return this.firstName + " " + this.lastName;
        }

        public string genericHello()
        {
            return "Hi, how are you?";

        }

        public string hello()
        {
            return "Hello, how are you, my name is" + fullName();
        }
    }
}
