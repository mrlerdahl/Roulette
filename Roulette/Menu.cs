using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Menu
    {
        public static bool StartGameChoice(string input)
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
                StartGameChoice(Console.ReadLine());
            }
            return false;
        }
    }
}
