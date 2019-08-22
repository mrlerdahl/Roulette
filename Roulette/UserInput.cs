using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class UserInput
    {
        public static string GetString()
        {
            string input = Console.ReadLine();
            return input;
        }

        public static int GetNumber()
        {
            int input = Validation.NumberValidation(Console.ReadLine());
            return input;
        }
    }
}
