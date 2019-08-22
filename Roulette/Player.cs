using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Player
    {
        public int cashAmount { get; private set; }

        public Player(int enterCashAmount)
        {
            this.cashAmount = enterCashAmount;
        }
        public int PlaceMoneyBet(int moneyBet, bool isBetWin)
        {
            if (isBetWin)
            {
                return moneyBet * 2;
            }

            return -moneyBet;
        }

        public int AfterBetCashAmount(int cash)
        {
            cashAmount += cash;

            return cashAmount;
        }

        public bool IsStillHaveCash()
        {
            if (cashAmount <= 0)
                return false;

            return true;
        }

    }
}
