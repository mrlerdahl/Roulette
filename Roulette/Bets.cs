using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{

    // ****** DISPLAY CORNERS SUCH AS 1. 1/2/4/5 2. 23/24/26/27
    // ****** DO SAME WITH OTHER BETS
    public class Bets
    {
        public static int PlaceMoneyBet(int moneyBet, bool isBetWin)
        {
            return moneyBet;
        }

        public static bool Number(int chooseNumber = 0, int binResult = 0)
        {
            return false;
        }

        public static bool EvensOdds(string chooseEvensOrOdds = "even", int binResult = 0)
        {
            return false;
        }

        public static bool RedsBlacks(string chooseColor = "black", string binResult = "red")
        {
            return false;
        }

        public static bool LowsHighs(string chooseLowOrHigh = "Low", int binResult = 0)
        {
            return false;
        }

        public static bool Dozens(string chooseDozens = "First", int binResult = 0)
        {
            return false;
        }

        public static bool Columns(string chooseColumn = "Column1", int binResult = 0)
        {
            return false;
        }

        public static bool Street(int chooseRow = 0, int binResult = 0)
        {
            return false;
        }

        public static bool SixNumbers(int chooseDoubleRow = 0, int binResult = 0)
        {
            return false;
        }

        public static bool Split(int choserFirstNumber = 0, int chooseSecondNumber = 0, int binResult = 0)
        {
            return false;
        }

        public static bool Corner(int chooseCorner = 0, int binResult = 0)
        {
            return false;
        }
    }
}
