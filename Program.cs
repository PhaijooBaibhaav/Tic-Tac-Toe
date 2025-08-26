using System;  
class UI {
   static void Main(string [] args) {
     Console.WriteLine("Tic-Tac-Toe game");
     Program.showGrid(); 
   }
}

class Program {
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


