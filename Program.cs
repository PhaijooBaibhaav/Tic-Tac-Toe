using System;
namespace TicTacToe
{
    class UI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic-Tac-Toe game");
            while (Program.isPlaying)
            {
                Program.ShowGrid();

                if (Program.isPlayer1turn)
                {
                    Console.WriteLine("Player1's turn!");
                    Program.player = Program.player1Symbol;
                }
                else
                {
                    Console.WriteLine("Player2's turn!");
                    Program.player = Program.player2Symbol;
                }


                Program.isPlayer1turn = !Program.isPlayer1turn;

                Program.count++;

                Console.WriteLine("Write your turn: ");
                int turn = Convert.ToInt32(Console.ReadLine());

                Program.GetInput(turn, Program.player);

                if (Program.CheckIfWon(Program.player))
                {
                    Console.WriteLine($"{Program.player} won!");
                    Program.isPlaying = false;

                }
                else if (Program.count == 9)
                {
                    Console.WriteLine("It is a draw!");
                    Program.isPlaying = false;
                }


            }
            Console.ReadKey();
        }
    }

    class Program
    {

        public static string player1Symbol = "X";
        public static string player2Symbol = "O";
        public static bool isPlaying = true;
        public static bool isPlayer1turn = true;
        public static int count = 0;
        public static string player = "-1";

        public static string[,] cells =  { // string[][] can also be used
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };

        public static void ShowGrid()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    Console.Write(' ' + cells[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine();
                Console.WriteLine(" " + "~-~-~-~-");
            }
        }

        public static void GetInput(int turn, string player)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {



                    if (cells[i, j] == turn.ToString())
                    {


                        if (cells[i, j] == "X" || cells[i, j] == "O")
                        {
                            Console.WriteLine("This cell has already been taken!");
                            return ; /* exits the function here */
                        }

                        cells[i, j] = player;
                        return ;
                        Console.Clear();
                    }
                }
            }
        }

        public static bool CheckIfWon(string player)
        {

            for (int i = 0; i < 3; i++)
            {
                if (cells[i, 0] == player && cells[i, 1] == player && cells[i, 2] == player)
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (cells[0, i] == player && cells[1, i] == player && cells[2, i] == player)
                {
                    return true;
                }
            }

            if (cells[0, 0] == player && cells[1, 1] == player && cells[2, 2] == player)
            {
                return true;
            }

            if (cells[2, 0] == player && cells[1, 1] == player && cells[0, 2] == player)
                return true;

            return false;
        }

        public static bool CheckError(int turn) 
        {
            if (turn < 1 || turn > 9) {
                Console.WriteLine("Invalid input!");
                return true;
            }

            string turnInStr = turn.ToString();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (cells[i, j] == turnInStr)
                    {
                        // Cell is valid and not taken
                        return false;
                    }
                }
            }

            Console.WriteLine("This cell has already been taken!");
        }
    }
}

// cells.GetLength(0); for first dimension of 1D
// and (1) for 2d

