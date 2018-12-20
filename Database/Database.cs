using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            DAO theDao = new DAO();
            List<Todo> theList = theDao.list();
            string userInput = " ";
            string id;
            string yesNo;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("-------TO DO APP-------");
            Console.WriteLine("--By: Forrest Flowers--");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(1500);

            while (userInput != "exit")
            {
                Console.WriteLine("Please enter 'add', 'remove', 'list','update' 'list done' or 'exit'");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "add")
                {
                    Console.WriteLine("Do you want to add a task?");
                    yesNo = Console.ReadLine();

                    if (yesNo == "yes" || yesNo == "y")
                    {
                        Console.WriteLine("Enter a task:");
                        string task = Console.ReadLine();
                        theDao.add(task);
                        theDao.save();
                    }
                    else
                    {
                        Console.WriteLine("Returning to menu...");
                    }
                }
                else if (userInput == "list")
                {
                    foreach (Todo item in theDao.list())
                    {
                        Console.WriteLine(item);
                    }
                }
                /*  -Make sure you actually want to add something.
                    -Enter the Id to lookup.
                    -Calls the GetTodo method
                    -Use it to grab the Todo with that Id
                    -Put the Todo in remove method.
                 */
                else if (userInput == "remove")
                {
                    Console.WriteLine("Do you want to delete an entry?(Y/N)");
                    yesNo = Console.ReadLine().ToLower();
                    if (yesNo == "yes" || yesNo == "y")
                    {
                        Console.WriteLine("Enter the id of the task you want to remove.");
                        id = Console.ReadLine();
                        Todo removeItem = theDao.GetTodo(id);
                        theDao.remove(removeItem);
                        theDao.save();

                        Console.WriteLine("Deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Gotcha, returning to menu...");
                    }
                }
                else if (userInput == "update")
                {
                    Console.WriteLine("Do you want to mark a task as complete? (Y/N)");
                    yesNo = Console.ReadLine().ToLower();
                    if (yesNo == "yes" || yesNo == "y")
                    {
                        Console.WriteLine("Enter the id of a task to mark as complete");
                        id = Console.ReadLine();
                        Todo markAsDone = theDao.GetTodo(id);
                        markAsDone.Status = true;
                        theDao.save();
                    }
                    else
                    {
                        Console.WriteLine("Gotcha, returning to menu...");
                    }
                }
                else if (userInput == "list done")
                {
                    foreach (Todo item in theDao.listDone())
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (userInput == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }


            }

        }
    }

    // Cookie Cutter Todo Class
    public class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool Status { get; set; }

        public Todo(int Id, string Task)
        {
            this.Id = Id;
            this.Task = Task;
        }

        public Todo(string Task)
        {
            this.Task = Task;
        }

        override
        public string ToString()
        {
            return Id + ": " + Task + " | " + (Status ? "Complete" : "Incomplete");
        }
    }

    public class DAO
    {
        public Context context;
        public DAO()
        {
            context = new Context();
            context.Database.EnsureCreated();
        }

        public List<Todo> list()
        {
            List<Todo> allItems = new List<Todo>();
            foreach (Todo item in context.myList)
            {
                allItems.Add(item);
            }
            return allItems;
        }

        //Add an items to the database.
        public void add(string task)
        {
            context.myList.Add(new Todo(task));
        }

        //Search a single item in the database by Id.
        public Todo GetTodo(string findId)
        {
            foreach (Todo item in context.myList)
            {
                if (item.Id.ToString() == findId)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Todo> listDone()
        {
            List<Todo> doneList = new List<Todo>();

            foreach (Todo item in context.myList)
            {
                if (item.Status == true)
                {
                    doneList.Add(item);
                }
            }
            return doneList;
        }

        public void remove(Todo removeItem)
        {
            context.myList.Remove(removeItem);
        }

        public void save()
        {
            context.SaveChanges();
        }

    }

    //Sets up the database.
    public class Context : DbContext
    {
        public DbSet<Todo> myList { get; set; }
        override
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename =./todo.db");
        }
    }
}