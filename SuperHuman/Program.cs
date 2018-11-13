using System;

namespace SuperHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            Human john = new Human("Joe", "Male");
            Human clark = new SuperHuman("Clark", "Male", "Everything");
            SuperHuman bruce = new SuperHuman("Bruce", "Male", "Money");

            Console.WriteLine(john.greetings());
            Console.WriteLine(bruce.greetings());
        }
    }

   class Human
    {
       public string name {get;private set;}
       public string gender{get;private set;}

       public Human(string name, string gender)
        {
            this.name = name;
            this.gender = gender;
        }

        virtual public string greetings()
        {
            return "Hi, my name is "+name;
        }
    }

    class SuperHuman : Human
    {
        public string superPower{get;private set;}

       public SuperHuman(string name, string gender, string superPower) : base(name, gender)
        {
            this.superPower =superPower;
        }

        override
       public string greetings()
        {
            return "Hi, my name is "+name+" and my power is " +superPower;
        }
    }
}
