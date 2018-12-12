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
            // intro game
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Y'ALL WANNA PLAY CHECKERS?");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(2000);
            //make sure encoding is instantiated for printing checker objects
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Gets the game running.
            Game game = new Game();

            Console.ReadLine();

        }
    }
    //Basic Checker Class. Symbol is the unicode symbol, Color is the "team", Position it it's location on the grid.
    public class Checker
    {
        public string Color { get; set; }
        public string Symbol { get; set; }
        public int[] Position { get; set; }


        public Checker(string color, int[] position)
        {
            int colorOfPiece;

            if (color == "black")
            {
                //closed circle for black pieces.
                colorOfPiece = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                //open circle for white pieces
                colorOfPiece = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
            }
            this.Symbol = char.ConvertFromUtf32(colorOfPiece);
            this.Position = position;
            this.Color = color;
        }
    }

    public class Board
    {
        //variable needed for jumping
        public Checker check;
        //the grid is the array used to draw the board
        public string[][] Grid { get; set; }
        //list of checker objects used to position checkers on the board
        public List<Checker> Checkers { get; set; }

        public Board()
        {
            //The board needs checkers when it's made. 
            this.Checkers = new List<Checker>();
            this.CreateBoard();
            return;
        }

        public void CreateBoard()
        {
            // Makes the actual game grid.
            this.Grid = new string[][] {
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
            };
            return;
        }

        public void GenerateCheckers()
        {
            // white checkers starting position array
            int[][] whiteCheckers = new int[][] {
                new int[] { 0, 1 }, new int[] { 0, 3 }, new int[] { 0, 5 }, new int[] { 0, 7 },
                new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 1, 6 },
                new int[] { 2, 1 }, new int[] { 2, 3 }, new int[] { 2, 5 }, new int[] { 2, 7 }
            };

            //black checkers starting position array
            int[][] blackCheckers = new int[][] {
                new int[] { 5, 0 }, new int[] { 5, 2 }, new int[] { 5, 4 }, new int[] { 5, 6 },
                new int[] { 6, 1 }, new int[] { 6, 3 }, new int[] { 6, 5 }, new int[] { 6, 7 },
                new int[] { 7, 0 }, new int[] { 7, 2 }, new int[] { 7, 4 }, new int[] { 7, 6 }
            };

            //loops through and gives assigns a color to each checker.
            for (int i = 0; i < 12; i++)
            {
                Checker white = new Checker("white", whiteCheckers[i]);
                Checker black = new Checker("black", blackCheckers[i]);
                this.Checkers.Add(white);
                this.Checkers.Add(black);
            }
            return;
        }

        //Uses our grid and checker pieces to draw up a board.
        public void DrawBoard()
        {
            //The numbers for columns.
            Console.WriteLine("  0 1 2 3 4 5 6 7");
            //Loops through and adds numbers for rows.
            for (int i = 0; i < Grid.Length; i++)
            {
                string column = $"{i} ";

                for (int e = 0; e < Grid[i].Length; e++)
                {
                    column += $"{Grid[i][e]} ";
                }

                Console.WriteLine(column);
            }
            return;
        }

        // this is a method to place checkers on a board when a position is declared (pre || post validation)
        public void PlaceCheckers()
        {

            foreach (Checker checker in Checkers)
            {
                this.Grid[checker.Position[0]][checker.Position[1]] = checker.Symbol;
            }
            return;
        }

        // if row or column are greater than array throw exception
        // ELSE
        //queries a checker object and finds the checker the user asked for
        public Checker SelectInitChecker(int initRow, int initColumn)
        {
            //
            if ((initRow < 0 || initRow > 7) || (initColumn < 0 || initColumn > 7))
            {
                throw new Exception("You're trying to grab something that isn't on the board.");
            }
            else if (Checkers.Find(cx => cx.Position.SequenceEqual(new List<int> { initRow, initColumn })) == null)
            {
                throw new Exception("There's no checker there..");
            }
            return Checkers.Find(cx => cx.Position.SequenceEqual(new List<int> { initRow, initColumn }));
        }

        public Checker SelectCheckerDestination(int destRow, int destColumn)
        {
            Checker check = Checkers.Find(cx => cx.Position.SequenceEqual(new List<int> { destRow, destColumn }));
            //if Init row and column in array
            if ((destRow < 0 || destRow > 7) || (destColumn < 0 || destColumn > 7))
            {
                throw new Exception("Your move is off the board.");
            }
            return Checkers.Find(cx => cx.Position.SequenceEqual(new List<int> { destRow, destColumn }));
        }

        //Makes sure move is legal, otherwise it will throw an exception.
        public Checker CheckerPreCheck(int initRow, int initColumn, int destRow, int destColumn, Checker check)
        {
            check = Checkers.Find(cx => cx.Position.SequenceEqual(new List<int> { initRow, initColumn }));
            // if dest row and dest col have a checker piece using select checker method passing dest
            if (SelectCheckerDestination(destRow, destColumn) != null)
            {
                throw new Exception("There's already a checker there.");
            }
            else if (SelectCheckerDestination(destRow, destColumn) == null)
            {
                //if moving 2 diagonal spaces there must be enemy checker.
                //1. check if moving two spots (X)
                //2. check if destination removal is not null
                //3. checker symbol being jumped is an enemy piece.
                if (Math.Abs(destRow - check.Position[0]) == 2 && Math.Abs(destColumn - check.Position[1]) == 2)
                {
                    // for black checkers

                    //remove the checker row up  to column right
                    if (destRow - check.Position[0] == -2 && destColumn - check.Position[1] == 2)
                    {
                        RemoveChecker(destRow + 1, destColumn - 1);
                    }
                    //remove the checker row up to column left
                    else if (destRow - check.Position[0] == -2 && destColumn - check.Position[1] == -2)
                    {
                        RemoveChecker(destRow + 1, destColumn + 1);
                    }
                    //for white checkers

                    //remove the checker row behind me to column right
                    else if (destRow - check.Position[0] == 2 && destColumn - check.Position[1] == 2)
                    {
                        RemoveChecker(destRow - 1, destColumn - 1);
                    }
                    //remove the checker down to left
                    else if (destRow - check.Position[0] == 2 && destColumn - check.Position[1] == -2)
                    {
                        RemoveChecker(destRow - 1, destColumn + 1);
                        //Console.WriteLine ("Nice Jump white, removed checker behind you and to the left ");
                    }

                    //check for a diagonal move - regular
                }
                else if (Math.Abs(destRow - check.Position[0]) == 1 &&
                  Math.Abs(destColumn - check.Position[1]) == 1)
                {
                    return Checkers.Find(cx => cx.Position.SequenceEqual(new List<int> { destRow, destColumn }));
                }
                else
                {
                    Console.WriteLine(" ");
                    throw new Exception("You cannot move here. Does not meet requirements to move.");
                }
            }
            return Checkers.Find(cx => cx.Position.SequenceEqual(new List<int> { destRow, destColumn }));
        }

        //Get those pesky checkers outta there.
        public void RemoveChecker(int destRow, int destColumn)
        {
            Checker cx2 = SelectCheckerDestination(destRow, destColumn);
            Checkers.Remove(cx2);
        }

        public bool CheckForWin()
        {
            if (Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white"))
            {
                Console.WriteLine("White Won!");
                return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
            }
            else if (Checkers.All(x => x.Color == "black") || !Checkers.Exists(x => x.Color == "black"))
            {
                Console.WriteLine("Black Won!");
                return Checkers.All(x => x.Color == "black") || !Checkers.Exists(x => x.Color == "black");
            }
            else
            {
                Console.WriteLine("Keep Rolling.");
            }
            return false;
        }

        //Takes starting and ending positions and makes sure they're on the board.
        public void MoveCheckers()
        {

            Console.WriteLine("(Choose a number between 0-7)");
            Console.WriteLine("Pick up Checker on Row: ");
            int initRow = Int32.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Pick up Checker on Column: ");
            int initColumn = Int32.Parse(Console.ReadLine().Trim());
            Checker cx = SelectInitChecker(initRow, initColumn);
            //Asks user for a destination row/column to place checker in the field
            //return checker position played
            Console.WriteLine("Place Checker on Row: ");
            int destRow = Int32.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Place Checker on Column: ");
            int destColumn = Int32.Parse(Console.ReadLine().Trim());
            CheckerPreCheck(initRow, initColumn, destRow, destColumn, check);
            cx.Position = new int[] { destRow, destColumn };
            //creates the board again
            CreateBoard();
            //places checkers on the new board.
            PlaceCheckers();
            return;
        }

    }

    class Game
    {
        public Game()
        {
            // turns
            bool turn = true;

            //initialize the game by creating a board object and apply board methods
            Board board = new Board();
            board.CreateBoard();
            board.GenerateCheckers();
            board.PlaceCheckers();
            Console.WriteLine("Give me the coordinates of the checker you want to move, then where you want it to go.");
            do
            {
                //draw the board to play. on loop checkers will remember they have new positions.
                //try again for try catch exceptions.
                //Open how to play
                //Console.WriteLine ("To play you will select rows and columns\nto move pieces throughout the field.");
                if (turn)
                {
                    Console.WriteLine();
                    Console.WriteLine("white, Make Your Move");
                    turn = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Black, Make Your Move");
                    turn = true;
                }
            TryAgain: board.DrawBoard();

                try
                {
                    board.MoveCheckers();
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("There was an error:\n{0}", e.Message);
                    Console.WriteLine("Give it another shot.");
                    Console.WriteLine();
                    goto TryAgain;
                }
            }
            while (!board.CheckForWin());

        }
    }
}