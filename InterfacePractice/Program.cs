using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat b1 = new Boat(40);
            Boat b2 = new Boat(100);

            Room r1 = new Room(145);
            Room r2 = new Room(300);

            List<IRentable>  stuffToRent = new List<IRentable>();
        }
    }

    public interface IRentable
    {
        double GetDailyRate();
    }

    public class Boat
    {
       public double hourlyRate;
       public Boat(double hourly)
       {
           this.hourlyRate = hourly;
       }

       public double GetDailyRate()
       {
           return hourlyRate*24;
       }
    }

    public class Room
    {
        public double dailyRate;
        public Room(double daily)
        {
            this.dailyRate = daily;
        }
        public doublele GetDailyRate()
        {
            return dailyRate;
        }
    }
}
