using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class PlayGame
    {
        public PlayGame()
        {
            WriteText.StartGameText();
            WriteText.EnterChoice();
            QuitGame(!Menu.StartGameChoice(Console.ReadLine()));
            Console.Clear();

            RouletteWheel[] gameWheel = RouletteWheel.ConstructWheel();
            

        }

        public static void QuitGame(bool quit)
        {
            if(quit)
            Environment.Exit(0);
        }
       
    }
}
