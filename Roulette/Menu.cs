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
                WriteText.InvalidInputText();
                WriteText.TypesYesOrNo();
                YesOrNo(Console.ReadLine());
            }
            return true;
        }

    }
}
