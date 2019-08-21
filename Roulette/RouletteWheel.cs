using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class RouletteWheel
    {
        public int BinNumber { get; }
        public string BinColor { get; }

        public RouletteWheel(int setBinNumber, string setBinColor)
        {
            BinNumber = setBinNumber;
            BinColor = setBinColor;
        }

        public RouletteWheel SpinWheel(RouletteWheel[] binArray)
        {
            Random r = new Random();

            return binArray[r.Next(37)];
        }

        public static RouletteWheel[] ConstructWheel()
        {
            RouletteWheel[] gameWheel = new RouletteWheel[38];
            gameWheel[0] = new RouletteWheel(0, "green");
            gameWheel[1] = new RouletteWheel(1, "red");
            gameWheel[2] = new RouletteWheel(2, "black");
            gameWheel[3] = new RouletteWheel(3, "red");
            gameWheel[4] = new RouletteWheel(4, "black");
            gameWheel[5] = new RouletteWheel(5, "red");
            gameWheel[6] = new RouletteWheel(6, "black");
            gameWheel[7] = new RouletteWheel(7, "red");
            gameWheel[8] = new RouletteWheel(8, "black");
            gameWheel[9] = new RouletteWheel(9, "red");
            gameWheel[10] = new RouletteWheel(10, "black");
            gameWheel[11] = new RouletteWheel(11, "black");
            gameWheel[12] = new RouletteWheel(12, "red");
            gameWheel[13] = new RouletteWheel(13, "black");
            gameWheel[14] = new RouletteWheel(14, "red");
            gameWheel[15] = new RouletteWheel(15, "black");
            gameWheel[16] = new RouletteWheel(16, "red");
            gameWheel[17] = new RouletteWheel(17, "black");
            gameWheel[18] = new RouletteWheel(18, "red");
            gameWheel[19] = new RouletteWheel(19, "red");
            gameWheel[20] = new RouletteWheel(20, "black");
            gameWheel[21] = new RouletteWheel(21, "red");
            gameWheel[22] = new RouletteWheel(22, "black");
            gameWheel[23] = new RouletteWheel(23, "red");
            gameWheel[24] = new RouletteWheel(24, "black");
            gameWheel[25] = new RouletteWheel(25, "red");
            gameWheel[26] = new RouletteWheel(26, "black");
            gameWheel[27] = new RouletteWheel(27, "red");
            gameWheel[28] = new RouletteWheel(28, "black");
            gameWheel[29] = new RouletteWheel(29, "black");
            gameWheel[30] = new RouletteWheel(30, "red");
            gameWheel[31] = new RouletteWheel(31, "black");
            gameWheel[32] = new RouletteWheel(32, "red");
            gameWheel[33] = new RouletteWheel(33, "black");
            gameWheel[34] = new RouletteWheel(34, "red");
            gameWheel[35] = new RouletteWheel(35, "black");
            gameWheel[36] = new RouletteWheel(36, "red");
            gameWheel[37] = new RouletteWheel(00, "green");

            return gameWheel;
        }

        //public int GetBinNumber(RouletteWheel binNumber)
        //{
        //    return binNumber.BinNumber;
        //}
    }
}
