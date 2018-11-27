using System;

namespace structPractice
{
    class Program
    {
        // struct FullName
        // {
        //     string firstName;
        //     string middleName;
        //     string lastName;
        //     string prefix;
        //     string suffix;
        // }

        struct Address
        {
           public string street1;
           public string street2;
           public string city;
           public State state;

            override
           public string ToString()
           {
               return string.Format("{0} {1} {2}, {3}", street1, street2, city, state);
           }
        }

        public enum State
        {
            TX, NM, FL, OH, GA
        }
        static void Main(string[] args)
        {
            Address myAddress = new Address();

            myAddress.street1 ="1234 Main ST.";
            myAddress.city = "Austin";
            myAddress.state = State.TX;

            Console.WriteLine(myAddress);
        }
    }
}
