
using System;

namespace TicTacToe
{
    class Program
    {
        //Starting turn.
        public static string playerTurn = "X";
        //board array is used to create the board and hold the data for the game.
        public static string[][] board = new string[][] {
            new string[] { " ", " ", " " },
            new string[] { " ", " ", " " },
            new string[] { " ", " ", " " }
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();
            } while (!CheckForWin() && !CheckForTie());
            if (CheckForWin() == true)
            {
                DrawBoard();
                Console.WriteLine("{0} LOSES.!", playerTurn);
            }
            else if (CheckForTie() == true)
            {
                DrawBoard();
                Console.WriteLine("You tied!");
            }
            Console.ReadLine();

            bool test = true;
            if (!test)
            {
                test = testXO();
                Console.WriteLine("Your test is {0}", test);
            }
            else
            {
                Console.WriteLine("Your test is {0}", test);
            }
        }
        //getInput fx takes user input and uses it to fill board and call PlaceMark
        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
            playerTurn = (playerTurn == "X") ? "O" : "X";
        }

        public static string PlaceMark(int row, int column)
        {
            if (board[row][column] == " ")
            {
                board[row][column] = playerTurn;
                return playerTurn;
            }
            else if (board[row][column] == "X" || board[row][column] == "O")
            {
                Console.WriteLine("There's something here, Chief.");
                GetInput();
                //Changes Turn.
                playerTurn = (playerTurn == "X") ? "O" : "X";
            }
            return playerTurn;
        }
        //checks all win conditions for a win.
        public static bool CheckForWin()
        {
            if (HorizontalWin() == true)
            {
                return true;
            }
            else if (VerticalWin() == true)
            {
                return true;
            }
            else if (DiagonalWin() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //looks at the number of spaces - players keep going until you win or tie.
        public static bool CheckForTie()
        {
            // your code goes here
            int spaceAvail = 9;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == "X" || board[i][j] == "O")
                    {
                        spaceAvail--;
                    }
                }
            }
            if (spaceAvail <= 0 && !CheckForWin() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HorizontalWin()
        {
            if (board[0][0] == "X" && board[0][1] == "X" && board[0][2] == "X")
            {
                return true;
            }
            else if (board[0][0] == "O" && board[0][1] == "O" && board[0][2] == "O")
            {
                return true;
            }
            else if (board[1][0] == "X" && board[1][1] == "X" && board[1][2] == "X")
            {
                return true;
            }
            else if (board[1][0] == "O" && board[1][1] == "O" && board[1][2] == "O")
            {
                return true;
            }
            else if (board[2][0] == "X" && board[2][1] == "X" && board[2][2] == "X")
            {
                return true;
            }
            else if (board[2][0] == "O" && board[2][1] == "O" && board[2][2] == "O")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerticalWin()
        {
            //Checks each column for a veritical win.
            if (board[0][0] == "X" && board[1][0] == "X" && board[2][0] == "X")
            {
                return true;
            }
            else if (board[0][0] == "O" && board[1][0] == "O" && board[2][0] == "O")
            {
                return true;
            }
            else if (board[0][1] == "X" && board[1][1] == "X" && board[2][1] == "X")
            {
                return true;
            }
            else if (board[0][1] == "O" && board[1][1] == "O" && board[2][1] == "O")
            {
                return true;
            }
            else if (board[0][2] == "X" && board[1][2] == "X" && board[2][2] == "X")
            {
                return true;
            }
            else if (board[0][2] == "O" && board[1][2] == "O" && board[2][2] == "O")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DiagonalWin()
        {
            if (board[0][0] == "X" && board[1][1] == "X" && board[2][2] == "X")
            {
                return true;
            }
            else if (board[0][0] == "O" && board[1][1] == "O" && board[2][2] == "O")
            {
                return true;
            }
            else if (board[0][2] == "O" && board[1][1] == "O" && board[2][0] == "O")
            {
                return true;
            }
            else if (board[0][2] == "O" && board[1][1] == "O" && board[2][0] == "O")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2 ");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  ------");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  ------");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }

        public static bool testXO()
        {
            PlaceMark(0, 0);
            PlaceMark(1, 0);
            PlaceMark(0, 1);
            PlaceMark(1, 1);
            PlaceMark(0, 2);
            if (CheckForWin() == true)
            {
                if (HorizontalWin() == true)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}