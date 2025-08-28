using System;  
class UI {
   static void Main(string [] args) {
     Console.WriteLine("Tic-Tac-Toe game");
     while (Program.isPlaying)
     {
        Program.showGrid(); 
        break;

        if (isPlayer1Playing)
        {
            Console.WriteLine("Choose what you want to play as: \n1. X \n2. O");
            string choose = Console.ReadLine();

            getGamemodePly1(choosePly1);

           Console.WriteLine($"{choosePly1}'s turn."); 
        }

        else
        {
           getGamemodPly2(choosePly2);
           Console.WriteLine($"{choosePly2}'s turn.");
        }
     }
     Console.ReadKey();
   }
}

class Program {

   public static bool isPlaying = true;
   bool isPlayer1Playing = true;
   
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

    public static string getGamemodePly1(choose) {
       if (choosePly1 == 1)
       {
         return "X";           
       }

       else
       {
           return "Y";
       }
    }

    public static string getGamemodPly2() {
      if(choosePly1 == "X") 
      {
         return "Y";
      }
      
      else
      {
          return "X";
      }
    }
    
}

// cells.GetLength(0); for first dimension of 1D
// and (1) for 2d
