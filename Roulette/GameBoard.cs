using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class GameBoard
    {
        // Grabbed this code from Nathaniel Atmar's GitHub
        // https://github.com/atmarnat/PlayRoulette/tree/master/PlayRoulette
        public static void DrawBoard() //drawns a board with the different bets to the size. purely AESTHETICS
        {
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n    +-----+-----+-----+-----+-----+-----+    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    | 1-18| EVEN| RED |BLACK| ODD |19-36|    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("+---+--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("| 0 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 3");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 6");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 9");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("12");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("15");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("18");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("21");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("24");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("27");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("30");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("33");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("36");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|3rd|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("| 0 +--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|---|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 2");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 5");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 8");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("11");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("14");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("17");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("20");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("23");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("26");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("29");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("32");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("35");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|2nd|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|   +--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("| 0 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 1");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 4");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 7");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("10");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("13");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("16");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("19");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("22");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("25");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("28");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("31");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("34");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|1st|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("+---+--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    |    1-12   |   13-24   |   25-36   |    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    +-----------+-----------+-----------+    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }
    }
}
