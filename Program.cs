using System;  
namespace Tic-Tac-Toe
{
class UI {
   static void Main(string [] args) {
     Console.WriteLine("Tic-Tac-Toe game");
     Program.showGrid(); 
   }
}

class Program {
   public static string [] cells = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

      static void showGrid() {
          for (int i = 0; i < 3; i++) {
             for (int j = 0; j < 3; j++) {
                Console.WriteLine();
                Console.WriteLine("~~~~~~");
            }
            Console.WriteLine(cells[i] + '|');
         }
          //end of loop and showGrid function//
      }
}
}
