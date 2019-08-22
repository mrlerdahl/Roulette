using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{

    public class Bet
    {
        public int MoneyBetHolder { get; }

        //public Bet()
        //{
        //    this.MoneyBetHolder = moneyBet;
        //}

        public static bool Number(int chooseNumber, int binResult)
        {
            if (chooseNumber == binResult)
                return true;

            return false;
        }

        public static bool EvensOdds(string chooseEvensOrOdds, int binResult)
        {
            if (binResult % 2 == 0 && chooseEvensOrOdds == "even")
                return true;
            if (binResult % 2 != 0 && chooseEvensOrOdds == "odd")
                return true;

            return false;
        }

        public static bool RedsBlacks(string chooseColor, string binResult)
        {
            if (chooseColor == binResult)
                return true;

            return false;
        }

        public static bool LowsHighs(string chooseLowOrHigh, int binResult)
        {
            if (chooseLowOrHigh == "low" && (binResult > 0 && binResult <= 18))
                return true;
            if (chooseLowOrHigh == "high" && (binResult >= 19 && binResult <= 36))
                return true;

            return false;
        }

        public static bool Dozens(string chooseDozens, int binResult)
        {
            if (chooseDozens == "first" && (binResult >= 1 && binResult <= 12))
                return true;
            if (chooseDozens == "second" && (binResult >= 13 && binResult <= 24))
                return true;
            if (chooseDozens == "third" && (binResult >= 25 && binResult <= 36))
                return true;
            return false;
        }

        public static bool Columns(string chooseColumn, int binResult)
        {

            if (chooseColumn == "column1")
            {
                for (int i = 1; i <= 36; i += 3)
                {
                    if (binResult == i)
                        return true;
                }
            }
            if (chooseColumn == "column2")
            {
                for (int i = 2; i <= 36; i += 3)
                {
                    if (binResult == i)
                        return true;
                }
            }
            if (chooseColumn == "column3")
            {
                for (int i = 3; i <= 36; i += 3)
                {
                    if (binResult == i)
                        return true;
                }
            }
            return false;
        }

        public static bool Street(int chooseRow, int binResult)
        {
            switch (chooseRow)
            {
                case 1:
                    if (binResult.Equals(1) || binResult.Equals(2) || binResult.Equals(3))
                        return true;
                    break;
                case 2:
                    if (binResult.Equals(4) || binResult.Equals(5) || binResult.Equals(6))
                        return true;
                    break;
                case 3:
                    if (binResult.Equals(7) || binResult.Equals(8) || binResult.Equals(9))
                        return true;
                    break;
                case 4:
                    if (binResult.Equals(10) || binResult.Equals(11) || binResult.Equals(12))
                        return true;
                    break;
                case 5:
                    if (binResult.Equals(13) || binResult.Equals(14) || binResult.Equals(15))
                        return true;
                    break;
                case 6:
                    if (binResult.Equals(16) || binResult.Equals(17) || binResult.Equals(18))
                        return true;
                    break;
                case 7:
                    if (binResult.Equals(19) || binResult.Equals(20) || binResult.Equals(21))
                        return true;
                    break;
                case 8:
                    if (binResult.Equals(22) || binResult.Equals(23) || binResult.Equals(24))
                        return true;
                    break;
                case 9:
                    if (binResult.Equals(25) || binResult.Equals(26) || binResult.Equals(27))
                        return true;
                    break;
                case 10:
                    if (binResult.Equals(28) || binResult.Equals(29) || binResult.Equals(30))
                        return true;
                    break;
                case 11:
                    if (binResult.Equals(31) || binResult.Equals(32) || binResult.Equals(33))
                        return true;
                    break;
                case 12:
                    if (binResult.Equals(34) || binResult.Equals(35) || binResult.Equals(36))
                        return true;
                    break;
                default:
                    break;
            }
            return false;
        }

        public static bool SixNumbers(int chooseDoubleRow = 0, int binResult = 0)
        {
            switch (chooseDoubleRow)
            {
                case 1:
                    if (binResult.Equals(1) || binResult.Equals(2) || binResult.Equals(3) || binResult.Equals(4) || binResult.Equals(5) || binResult.Equals(6))
                        return true;
                    break;
                case 2:
                    if (binResult.Equals(4) || binResult.Equals(5) || binResult.Equals(6) || binResult.Equals(7) || binResult.Equals(8) || binResult.Equals(9))
                        return true;
                    break;
                case 3:
                    if (binResult.Equals(7) || binResult.Equals(8) || binResult.Equals(9) || binResult.Equals(10) || binResult.Equals(11) || binResult.Equals(12))
                        return true;
                    break;
                case 4:
                    if (binResult.Equals(10) || binResult.Equals(11) || binResult.Equals(12) || binResult.Equals(13) || binResult.Equals(14) || binResult.Equals(15))
                        return true;
                    break;
                case 5:
                    if (binResult.Equals(13) || binResult.Equals(14) || binResult.Equals(15) || binResult.Equals(16) || binResult.Equals(17) || binResult.Equals(18))
                        return true;
                    break;
                case 6:
                    if (binResult.Equals(16) || binResult.Equals(17) || binResult.Equals(18) || binResult.Equals(19) || binResult.Equals(20) || binResult.Equals(21))
                        return true;
                    break;
                case 7:
                    if (binResult.Equals(19) || binResult.Equals(20) || binResult.Equals(21) || binResult.Equals(22) || binResult.Equals(23) || binResult.Equals(24))
                        return true;
                    break;
                case 8:
                    if (binResult.Equals(22) || binResult.Equals(23) || binResult.Equals(24) || binResult.Equals(25) || binResult.Equals(26) || binResult.Equals(27))
                        return true;
                    break;
                case 9:
                    if (binResult.Equals(25) || binResult.Equals(26) || binResult.Equals(27) || binResult.Equals(28) || binResult.Equals(29) || binResult.Equals(30))
                        return true;
                    break;
                case 10:
                    if (binResult.Equals(28) || binResult.Equals(29) || binResult.Equals(30) || binResult.Equals(31) || binResult.Equals(32) || binResult.Equals(33))
                        return true;
                    break;
                case 11:
                    if (binResult.Equals(31) || binResult.Equals(32) || binResult.Equals(33) || binResult.Equals(34) || binResult.Equals(35) || binResult.Equals(36))
                        return true;
                    break;
                default:
                    break;
            }
            return false;
        }

        public static bool Split(int chooseFirstNumber = 0, int chooseSecondNumber = 0, int binResult = 0)
        {
            if (chooseFirstNumber.Equals(binResult) || chooseSecondNumber.Equals(binResult))
                return true;
            return false;
        }

        public static bool Corner(int chooseCorner = 0, int binResult = 0)
        {

            switch (chooseCorner)
            {
                case 1:
                    if (binResult.Equals(1) || binResult.Equals(2) || binResult.Equals(4) || binResult.Equals(5))
                        return true;
                    break;
                case 2:
                    if (binResult.Equals(2) || binResult.Equals(3) || binResult.Equals(4) || binResult.Equals(6))
                        return true;
                    break;
                case 3:
                    if (binResult.Equals(4) || binResult.Equals(5) || binResult.Equals(7) || binResult.Equals(8))
                        return true;
                    break;
                case 4:
                    if (binResult.Equals(5) || binResult.Equals(6) || binResult.Equals(8) || binResult.Equals(9))
                        return true;
                    break;
                case 5:
                    if (binResult.Equals(7) || binResult.Equals(8) || binResult.Equals(10) || binResult.Equals(11))
                        return true;
                    break;
                case 6:
                    if (binResult.Equals(8) || binResult.Equals(9) || binResult.Equals(11) || binResult.Equals(12))
                        return true;
                    break;
                case 7:
                    if (binResult.Equals(10) || binResult.Equals(11) || binResult.Equals(13) || binResult.Equals(14))
                        return true;
                    break;
                case 8:
                    if (binResult.Equals(11) || binResult.Equals(12) || binResult.Equals(14) || binResult.Equals(15))
                        return true;
                    break;
                case 9:
                    if (binResult.Equals(13) || binResult.Equals(14) || binResult.Equals(16) || binResult.Equals(17))
                        return true;
                    break;
                case 10:
                    if (binResult.Equals(14) || binResult.Equals(15) || binResult.Equals(17) || binResult.Equals(18))
                        return true;
                    break;
                case 11:
                    if (binResult.Equals(16) || binResult.Equals(17) || binResult.Equals(19) || binResult.Equals(20))
                        return true;
                    break;
                case 12:
                    if (binResult.Equals(17) || binResult.Equals(18) || binResult.Equals(20) || binResult.Equals(21))
                        return true;
                    break;
                case 13:
                    if (binResult.Equals(19) || binResult.Equals(20) || binResult.Equals(22) || binResult.Equals(23))
                        return true;
                    break;
                case 14:
                    if (binResult.Equals(20) || binResult.Equals(21) || binResult.Equals(23) || binResult.Equals(24))
                        return true;
                    break;
                case 15:
                    if (binResult.Equals(22) || binResult.Equals(23) || binResult.Equals(25) || binResult.Equals(26))
                        return true;
                    break;
                case 16:
                    if (binResult.Equals(23) || binResult.Equals(24) || binResult.Equals(26) || binResult.Equals(27))
                        return true;
                    break;
                case 17:
                    if (binResult.Equals(25) || binResult.Equals(26) || binResult.Equals(28) || binResult.Equals(29))
                        return true;
                    break;
                case 18:
                    if (binResult.Equals(26) || binResult.Equals(27) || binResult.Equals(29) || binResult.Equals(30))
                        return true;
                    break;
                case 19:
                    if (binResult.Equals(28) || binResult.Equals(29) || binResult.Equals(31) || binResult.Equals(32))
                        return true;
                    break;
                case 20:
                    if (binResult.Equals(29) || binResult.Equals(30) || binResult.Equals(32) || binResult.Equals(33))
                        return true;
                    break;
                case 21:
                    if (binResult.Equals(31) || binResult.Equals(32) || binResult.Equals(34) || binResult.Equals(35))
                        return true;
                    break;
                case 22:
                    if (binResult.Equals(32) || binResult.Equals(33) || binResult.Equals(34) || binResult.Equals(35))
                        return true;
                    break;
                default:
                    break;
            }
            return false;
        }
    }
}
