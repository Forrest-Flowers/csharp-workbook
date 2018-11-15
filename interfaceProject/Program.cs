using System;
using System.Collections.Generic;

namespace interfaceProject
{
    public interface IYearly
    {
      int findYearlySalary();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Developer d1 = new Developer(40000);
            Developer d2 = new Developer(90000);

            Contractor c1 = new Contractor(400);
            Contractor c2 = new Contractor(700);

            Engineer e1 = new Engineer(4000);
            Engineer e2 = new Engineer(8000);

            List<IYearly> yearlySalaries = new List<IYearly>();
        }
    }

    class Developer
    {
        public int yearlySalary;

        public Developer(int yearly)
        {
            this.yearlySalary = yearly;
        }

        public int findYearlySalary()
        {
            return yearlySalary;
        }

    }

    class Contractor
    {
        public int weeklySalary;

        public Contractor(int weekly)
        {
            this.weeklySalary = weekly;
        }

        public int findYearlySalary()
        {
            return weeklySalary*52;
        }
    }

    class Engineer
    {
        public int monthlySalary;

        public Engineer(int monthly)
        {
            this.monthlySalary = monthly;
        }

        public int findYearlySalary()
        {
            return monthlySalary*12;
        }
    }
}
