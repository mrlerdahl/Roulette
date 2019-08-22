using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Menu
    {
        public static bool YesOrNo(string input)
        {
            if (input.ToLower() == "yes")
            {
                return true;
            }
            if (input.ToLower() == "no")
            {
                return false;
            }
            else
            {
                WriteText.InvalidEntryText();
                YesOrNo(Console.ReadLine());
            }
            return false;
        }

        public static int ChooseTypeOfBet()
        {
            Console.WriteLine(" Type a bet option, type 0 to stop placing bets, or type -1 to quit");
            return UserInput.GetNumber();
        }
    }
}
