using System;

class UI {
   static void Main(string [] args) {
     Console.WriteLine("Tic-Tac-Toe game");
     while (Program.isPlaying)
     {
        Program.showGrid(); 
        break;

         if(isPlayer1turn) {
            Console.WriteLine("Player1's turn!");
         } else {
            Console.WriteLine("Player2's turn!");
         }
         
         Console.WriteLine("Choose what do you want to play as: \n\t1. X \n\t2. Y");
         int choose = int.Parse(Console.ReadLine());


        
    }
     Console.ReadKey();
   }
}

class Program {

   public static bool isPlaying = true;
   public static bool isPlayer1turn = true;
   
   public static string [,] cells =  { // string[][] can also be used
                                       {"1", "2", "3"},
                                       {"4", "5", "6"},
                                       {"7", "8", "9"},
                                    };

    public static void showGrid() {
      for (int i = 0; i < cells.GetLength(0); i++) {
         for (int j = 0; j < cells.GetLength(1); j++) {
               Console.Write(' '+cells[i,j]);
               Console.Write("|");
            }
         Console.WriteLine();
         Console.WriteLine(" " + "~-~-~-~-");
         }
    }
}

// cells.GetLength(0); for first dimension of 1D
// and (1) for 2d
