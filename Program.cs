using System;
class UI {
   static void Main(string [] args) {
      
   }
}

class Program {
   string [] cells = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

  showGrid(); 
   public void showGrid() {
      for (int i = 0; i < 3; i++) {
        Console.WriteLine(cells[i + '|']);
      for (int j = 0; j < 3; j++) {
           Console.WriteLine("~~~~~~");
         }
      }
   }
}
