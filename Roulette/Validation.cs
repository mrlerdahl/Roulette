using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Roulette
{
    class Validation
    {
        // This is to validate that the user is not trying to enter an yletters 
        // nor enter any values below zero or above nine
        public static int NumberValidation(string valInput)
        {
            string userInput;
            int newInput;
            bool keepGoing = false;
            do
            {
                keepGoing = int.TryParse(valInput, out newInput);
                if (!keepGoing)
                {
                    WriteText.InvalidInputText();
                    WriteText.EnterChoice();
                    userInput = Console.ReadLine();
                    keepGoing = int.TryParse(userInput, out newInput);
                    //keepGoing = InRangeValidation(newInput);
                }
            } while (!keepGoing);

            return newInput;
        }
        // This is use to help the method above to check on last time that the 
        // numbers are in range before and send back to the above method weather its true or not
        static bool InRangeValidation(int valNum)
        {
            if (valNum <= 0 || valNum > 9)
            {
                return false;
            }

            return true;
        }


        // Use to make sure the user is entering a cash amount above zero
        // Also rechecks to make sure the user is only entering numbers
        public static int InRangeCashAmount(int valInput)
        {
            while(valInput < 0)
            {
                WriteText.InvalidAmount();
                WriteText.EnterAmount();
                valInput = NumberValidation(Console.ReadLine());
            }

            return valInput;
        }

        public static int NumbersChoiceValidation(int valInput)
        {
            while(valInput < 0 || valInput > 36)
            {
                WriteText.InvalidInputText();
                WriteText.EnterChoice();
                valInput = NumberValidation(Console.ReadLine());
            }

            return valInput;
        }

        public static string EvenOddValidation(string valInput)
        {
            valInput = Regex.Replace(valInput, "[s]", string.Empty);
            if (valInput.Equals("even"))
                return valInput;
            if (valInput.Equals("odd"))
                return valInput;
            else
            {
                WriteText.InvalidInputText();
                WriteText.EnterChoice();
                EvenOddValidation(Console.ReadLine());
            }


            return Regex.Replace(valInput, "[s]", string.Empty);
        }

        public static string RedBlackValidation(string valInput)
        {
            valInput = Regex.Replace(valInput, "[s]", string.Empty);
            if (valInput.Equals("red"))
                return valInput;
            if (valInput.Equals("black"))
                return valInput;
            else
            {
                WriteText.InvalidInputText();
                WriteText.EnterChoice();
                EvenOddValidation(Console.ReadLine());
            }


            return Regex.Replace(valInput, "[s]", string.Empty);
        }

        public static string LowHighValidation(string valInput)
        {
            valInput = Regex.Replace(valInput, "[s]", string.Empty);
            if (valInput.Equals("low"))
                return valInput;
            if (valInput.Equals("high"))
                return valInput;
            else
            {
                WriteText.InvalidInputText();
                WriteText.EnterChoice();
                EvenOddValidation(Console.ReadLine());
            }


            return Regex.Replace(valInput, "[s]", string.Empty);
        }

        public static string DozensValidation(string valInput)
        {
            if (valInput.Equals("first"))
                return valInput;
            if (valInput.Equals("second"))
                return valInput;
            if (valInput.Equals("third"))
                return valInput;
            else
            {
                WriteText.InvalidInputText();
                WriteText.EnterChoice();
                EvenOddValidation(Console.ReadLine());
            }


            return valInput;
        }

        public static string ColumnsValidation(string valInput)
        {
            valInput = Regex.Replace(valInput, "[s]", string.Empty);
            if (valInput.Equals("column1"))
                return valInput;
            if (valInput.Equals("column2"))
                return valInput;
            if (valInput.Equals("column3"))
                return valInput;
            else
            {
                WriteText.InvalidInputText();
                WriteText.EnterChoice();
                EvenOddValidation(Console.ReadLine());
            }


            return Regex.Replace(valInput, "[s]", string.Empty);
        }

        public static int StreetValidation(int valInput)
        {
            while (valInput <= 0 || valInput >= 13)
            {
                WriteText.InvalidInputText();
                WriteText.EnterChoice();
                valInput = NumberValidation(Console.ReadLine());
            }

            return valInput;
        }
    }
}
