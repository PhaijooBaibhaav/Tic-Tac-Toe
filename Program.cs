using System;
namespace Tic-Tac-Toe {
	class UI {
		static void Main(string [] args) {
			Console.WriteLine("Tic-Tac-Toe game");
			while (Program.isPlaying)
			{
				Program.ShowGrid(); 

				if(Program.isPlayer1turn) {
					Console.WriteLine("Player1's turn!");
				} else {
					Console.WriteLine("Player2's turn!");
				}


				Console.WriteLine("Choose what do you want to play as: \n\t1. X \n\t2. O");
				int chooseIndex = int.Parse(Console.ReadLine());

				string choose = Program.turns[chooseIndex];
				Program.isPlayer1turn =!Program.isPlayer1turn;

				Program.count++;

				break;
			}
			Console.ReadKey();
		}
	}

	class Program {

		public static string[] turns = {"X" , "O"};
		public static bool isPlaying = true;
		public static bool isPlayer1turn = true;
		public static int count = 0;

		public static string [,] cells =  { // string[][] can also be used
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

		public static void ShowGrid() {
			for ( int i = 0; i < cells.GetLength(0); i++) {
				for ( int j = 0; j < cells.GetLength(1); j++) {
					Console.Write(' '+cells[i,j]);
					Console.Write("|");
				}
				Console.WriteLine();
				Console.WriteLine(" " + "~-~-~-~-");
			}
		}

		public static bool CheckIfWon(string player) {

			for(int i = 0; i < 3; i++) {

				if (cells[i, 0] == player && cells[i, 1] == player && cells[i, 2] == player) {
					return true;
				}

			}

		}
	}
}

// cells.GetLength(0); for first dimension of 1D
// and (1) for 2d

//C:\Users\Ganga Ram Phaijoo\OneDrive\Documents\BP\csharp\tictactoe\Program.cs(57,27): error CS0443: Syntax error; value expected [C:\Users\Ganga Ram Phaijoo\OneDriv
//e\Documents\BP\csharp\tictactoe\tictactoe.csproj]
//C:\Users\Ganga Ram Phaijoo\OneDrive\Documents\BP\csharp\tictactoe\Program.cs(63,1): error CS1022: Type or namespace definition, or end-of-file expected [C:\Users\G
//anga Ram Phaijoo\OneDrive\Documents\BP\csharp\tictactoe\tictactoe.csproj]

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//if ((cells[0,0] == cells[0,1] && cells[0,1] == cells[0,2]) || 
//		(cells[1,0] == cells[1,1] && cells[1,1] == cells[1,2]) || 
//		(cells[2,0] == cells[2,1] && cells[2,1] == cells[2,2]) || 
//		(cells[0,0] == cells[1,0] && cells[1,0] == cells[2,0]) || 
//		(cells[0,1] == cells[1,1] && cells[1,1] == cells[2,1]) || 
//		(cells[0,2] == cells[1,2] && cells[1,2] == cells[2,2]) || 
//		(cells[0,0] == cells[1,1] && cells[1,1] == cells[2,2]) || 
//		(cells[0,2] == cells[1,1] && cells[1,1] == cells[2,0])) {

//	Console.WriteLine($"{} won.");

//}

//else if (count == 9) {
//	Console.WriteLine("It is a draw!"); 
//
