using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class GameBoard
    {
        int[] wheelNumbers = new int[38];
        string[] wheelColors = new string[] { "greenn", "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black",
                                                "red", "black", "red", "black", "red", "black", "red", "red", "black", "red", "black",
                                                "red", "black", "red", "black", "red", "black", "black", "red", "black", "red", "black",
                                                "red", "black", "red", "green" };

        public GameBoard()
        {
            for (int i = 0; i < 38; i++)
            {
                if (i == 37)
                    wheelNumbers[i] = 00;
                else
                    wheelNumbers[i] = i;
            }
        }

        public int SpinWheel()
        {
            int binNumber;
            Random r = new Random();
            binNumber = r.Next(37);

            return binNumber;
        }
    }
}
