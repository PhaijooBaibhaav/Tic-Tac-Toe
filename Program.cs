using System;  
class UI {
   static void Main(string [] args) {
     Console.WriteLine("Tic-Tac-Toe game");
     Program.showGrid(); 
   }
}

class Program {
   public static string [] cells = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

      public static void showGrid() {
          for (int i = 0; i < 3; i++) {
             for (int j = 0; j < 3; j++) {
               Console.Write(cells[i]);   
               Console.Write("|");
            }
            Console.WriteLine();
            Console.WriteLine("~~~~~~");
         }
          //end of loop and showGrid function//
      }
}
