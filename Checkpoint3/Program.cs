using System;
using System.Collections.Generic;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
        }
    }

    public class UserSays
    {
        public UserSays()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }

    public class Todo
    {
        public static int id;
        public string task { get; set; }
        public bool isComplete { get; set; }
        public List<string> tags { get; set; }

        public Todo(int id, string task)
        {

        }

    }

    //Controller
    public interface ITodo
    {

    }

    public class ToDoDAO
    {
        //Creates a new Todo object.
        public static void Add()
        {

        }
        //Takes an existing Todo object and allows you to edit it.
        public static void Update()
        {

        }
        //Lists all Todo objects.
        public static void GetAll()
        {

        }
        //Removes on Todo object by id
        public static void Remove()
        {

        }
        //Fetches one Todo object from database.
        public static GetTodo()
        {

        }
    }
}

