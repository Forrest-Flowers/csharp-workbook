using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("LET'S PLAY SOME CHECKERS!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");

            Thread.Sleep(1500);
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game game = new Game();

            Console.ReadLine();
        }
    }

    public class Checker
    {
        public string Symbol  { get; set; }
        public int[] Position  { get; set; }
        public string Color { get; set; }
        
        public Checker(string color, int[] position)
        {
            // Your code here
        }
    }

    public class Board
    {
        public string[][] Grid  { get; set; }
        public List<Checker> Checkers { get; set; }
        
        public Board()
        {
            // Your code here
            return;
        }
        
        public void CreateBoard()
        {
            this.Grid = new string[][] 
            {
                new string[] {" ", " ", " ", " ", " ", " ", " ", " ",},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " ",}
            };
        }
        
        public void GenerateCheckers()
        {
            // Your code here
            return;
        }
        
        public void PlaceCheckers()
        {
            foreach (var checker in Checkers)
            {
                this.Grid[checker.Position[0]][checker.Position[1]]
            }
            return;
        }
        
        public void DrawBoard()
        {
            // Your code here
            return;
        }
        
        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }
        
        public void RemoveChecker(int row, int column)
        {
            // Your code here
            return;
        }
        
        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
    }

    class Game
    {
        public Game()
        {
            // Your code here
        }
    }
}
