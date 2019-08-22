using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class WriteText
    {
        public static void StartGameText()
        {
            Console.WriteLine("  Play a game of Roulette?");
            Console.Write("  Type yes or no: ");
        }

        public static void EnterAmountOfMoney()
        {
            Console.Write("  Enter the amount of money you would like to start the game with: ");
        }
        public static void TypesOfBetsText()
        {
            Console.WriteLine("1. Numbers: the number of the bin");
            Console.WriteLine("2. Evens/Odds: even or odd numbers");
            Console.WriteLine("3. Reds/Blacks: red or black colored numbers");
            Console.WriteLine("4. Lows/Highs: low (1 { 18) or high (19 { 38) numbers.");
            Console.WriteLine("5. Dozens: row thirds, 1 { 12, 13 { 24, 25 { 36");
            Console.WriteLine("6. Columns: rst, second, or third columns");
            Console.WriteLine("7. Street: rows, e.g., 1/2/3 or 22/23/24");
            Console.WriteLine("8. 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26");
            Console.WriteLine("9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36");
            Console.WriteLine("10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");
        }

        public static void GetBetChoice()
        {
            Console.Write("\n  Select a bet number: ");
        }

        public static void EnterBetAmount()
        {
            Console.Write("  Enter bet amount: ");
        }

        public static void NumbersChoice()
        {
            Console.WriteLine("  Choose 0, 00, or any number from 1 to 36");
        }

        public static void EvensOddsChoice()
        {
            Console.WriteLine(" Choose by typing evens or odds");
        }

        public static void RedsBlacksChoice()
        {
            Console.WriteLine(" Choose by typing red or black");
        }

        public static void LowsHighsChoice()
        {
            Console.WriteLine(" Choose one of the following");
            Console.WriteLine(" Lows: 1 to 18");
            Console.WriteLine(" Highs: 19 to 36");
            Console.WriteLine(" Type low or high");
        }

        public static void DozensChoice()
        {
            Console.WriteLine(" Choose a row");
            Console.WriteLine(" First:  1 to 12");
            Console.WriteLine(" Second: 13 to 24");
            Console.WriteLine(" Third:  25 to 36");
            Console.WriteLine(" Type first, second, or third");
        }

        public static void ColumnsChoice()
        {
            Console.WriteLine(" Choose a Column");
            Console.WriteLine(" Column1: 1/4/7/10/13/16/19/22/25/28/31/34");
            Console.WriteLine(" Column2: 2/5/8/11/14/17/20/23/26/29/32/35");
            Console.WriteLine(" Column3: 3/6/9/12/15/18/21/24/27/30/33/36");
            Console.WriteLine(" Type column1, column2, column3");
        }

        public static void StreetChoice()
        {
            Console.WriteLine(" Choose a row number");
            Console.WriteLine(" 1.  1/2/3");
            Console.WriteLine(" 2.  4/5/6");
            Console.WriteLine(" 3.  7/8/9");
            Console.WriteLine(" 4.  10/11/12");
            Console.WriteLine(" 5.  13/14/15");
            Console.WriteLine(" 6.  16/17/18");
            Console.WriteLine(" 7.  19/20/21");
            Console.WriteLine(" 8.  22/23/24");
            Console.WriteLine(" 9.  25/26/27");
            Console.WriteLine(" 10. 28/29/30");
            Console.WriteLine(" 11. 31/32/33");
            Console.WriteLine(" 12. 34/35/36");
        }

        public static void SixNumbersChoice()
        {
            Console.WriteLine(" Choose a number option");
            Console.WriteLine(" 1. 1/2/3/4/5/6");
            Console.WriteLine(" 2. 7/8/9/10/11/12");
            Console.WriteLine(" 3. 13/14/15/16/17/18");
            Console.WriteLine(" 4. 19/20/21/22/23/24");
            Console.WriteLine(" 5. 25/26/27/28/29/30");
            Console.WriteLine(" 6. 21/32/33/34/35/36");
        }
        public static void SplitChoice()
        {
            Console.WriteLine(" Choose two adjacent numbers(numbers that are next to each other)");
        }

        public static void Corners()
        {
            Console.WriteLine(" Choose a number option");
            Console.WriteLine(" 1. 1|2|4|5");
            Console.WriteLine(" 2. 2/3/4/6");
            Console.WriteLine(" 3. 4/5/7/8");
            Console.WriteLine(" 4. 5/6/8/9");
            Console.WriteLine(" 5. 7/8/10/11");
            Console.WriteLine(" 6. 8/9/11/12");
            Console.WriteLine(" 7. 10/11/13/14");
            Console.WriteLine(" 8. 11/12/14/15");
            Console.WriteLine(" 9. 13/14/16/17");
            Console.WriteLine(" 10. 14/15/17/18");
            Console.WriteLine(" 11. 16/17/19/20");
            Console.WriteLine(" 12. 17/18/20/21");
            Console.WriteLine(" 13. 19/20/22/23");
            Console.WriteLine(" 14. 20/21/23/24");
            Console.WriteLine(" 15. 22/23/25/26");
            Console.WriteLine(" 16. 23/24/26/27");
            Console.WriteLine(" 17. 25/26/28/29");
            Console.WriteLine(" 18. 26/27/29/30");
            Console.WriteLine(" 19. 28/29/31/32");
            Console.WriteLine(" 20. 29/30/32/33");
            Console.WriteLine(" 21. 31/32/34/35");
            Console.WriteLine(" 22. 32/33/35/36");
        }

        public static void EnterChoice()
        {
            Console.Write("  Enter choice: ");
        }

        public static void InvalidEntryText()
        {
            Console.WriteLine("\n\t**Invalid Entry**\n");
        }
        public static void InvalidInputText()
        {
            Console.WriteLine("\n\t**Invalid input**\n");
        }

        public static void AskIfMoreBets()
        {
            Console.WriteLine("  Want to place more bets?");
            Console.Write("  Enter yes or no: ");
        }

        public static void LostBet()
        {
            Console.Write("  You lost: ");
        }
        public static void WonBet()
        {
            Console.Write("  You won: ");
        }
        public static void BrokeEven()
        {
            Console.Write(" You broke even: ");
        }

        public static void NewCashAmount()
        {
            Console.Write(" Your new cash amount: ");
        }

        public static void KeepPlaying()
        {
            Console.WriteLine(" Do you want to play again?");
            Console.Write(" Type yes or no: ");
        }
    }
}
