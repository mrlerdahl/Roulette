using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Roulette
{
    class PlayGame
    {
        public PlayGame()
        {
            WriteText.StartGameText();
            QuitGame(!Menu.YesOrNo(Console.ReadLine()));
            Console.Clear();

            RouletteWheel[] gameWheel = RouletteWheel.ConstructWheel();
            RouletteWheel binResult;
            List<int> ListOfBetResults = new List<int>();
            ConsoleSpinner spinner = new ConsoleSpinner();
            spinner.Delay = 300;
            Stopwatch s = new Stopwatch();
            int time = 7;
            int userBetSelection;
            int intChoice;
            string stringChoice;
            int moneyBet;
            bool userDecision = true;


            WriteText.EnterAmountOfMoney();
            Player user = new Player(Validation.InRangeCashAmount(UserInput.GetNumber()));
            Console.Clear();

            // Loop will keep running as long as the user keeps sayin yes to new bets
            while (userDecision)
            {

                // I will be getting the spin result from the start in order for my bet methods to work properly
                // When the wheel spins in code, it doesn't matter to the user
                // I'll display wheel spinning after bets are placed 
                // to make the user think the wheel spun after bets are placed
                binResult = RouletteWheel.SpinWheel(gameWheel);

                // once user tpyes no at the end of the loop it will then exit the loop
                while (userDecision)
                {

                    Console.Clear();

                    GameBoard.DrawBoard();
                    WriteText.TypesOfBetsText();
                    WriteText.GetBetChoice();
                    userBetSelection = UserInput.GetNumber();

                    
                    // Once a user picks a number the switch will pick the correct bet
                    // Each case will draw a board and output how to bet
                    // The bet is placed, then determines if its a win or lose then adds the money to a list to be added later
                    switch (userBetSelection)
                    {
                        case 1:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.NumbersChoice();
                            WriteText.EnterChoice();
                            intChoice = Validation.NumbersChoiceValidation(UserInput.GetNumber());
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.Number(intChoice, binResult.BinNumber)));
                            break;
                        case 2:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.EvensOddsChoice();
                            WriteText.EnterChoice();
                            stringChoice = Validation.EvenOddValidation(UserInput.GetString());
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.EvensOdds(stringChoice, binResult.BinNumber)));
                            break;
                        case 3:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.RedsBlacksChoice();
                            WriteText.EnterChoice();
                            stringChoice = Validation.RedBlackValidation(UserInput.GetString());
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.RedsBlacks(stringChoice, binResult.BinColor)));
                            break;
                        case 4:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.LowsHighsChoice();
                            WriteText.EnterChoice();
                            stringChoice = Validation.LowHighValidation(UserInput.GetString());
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.LowsHighs(stringChoice, binResult.BinNumber)));
                            break;
                        case 5:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.DozensChoice();
                            WriteText.EnterChoice();
                            stringChoice = Validation.DozensValidation(UserInput.GetString());
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.Dozens(stringChoice, binResult.BinNumber)));
                            break;
                        case 6:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.ColumnsChoice();
                            WriteText.EnterChoice();
                            stringChoice = Validation.DozensValidation(UserInput.GetString());
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.Columns(stringChoice, binResult.BinNumber)));
                            break;
                        case 7:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.StreetChoice();
                            WriteText.EnterChoice();
                            intChoice = Validation.StreetValidation(UserInput.GetNumber());
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.Street(intChoice, binResult.BinNumber)));
                            break;
                        case 8:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.SixNumbersChoice();
                            WriteText.EnterChoice();
                            intChoice = UserInput.GetNumber();
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.SixNumbers(intChoice, binResult.BinNumber)));
                            break;
                        case 9:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.SplitChoice();
                            WriteText.EnterChoice();
                            intChoice = UserInput.GetNumber();
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.Split(intChoice, binResult.BinNumber)));
                            break;
                        case 10:
                            Console.Clear();
                            GameBoard.DrawBoard();
                            WriteText.Corners();
                            WriteText.EnterChoice();
                            intChoice = UserInput.GetNumber();
                            WriteText.EnterBetAmount();
                            moneyBet = Validation.InRangeCashAmount(UserInput.GetNumber());
                            ListOfBetResults.Add(user.PlaceMoneyBet(moneyBet, Bet.Corner(intChoice, binResult.BinNumber)));
                            break;
                    }
                    Console.Clear();

                    WriteText.AskIfMoreBets();
                    userDecision = Menu.YesOrNo(UserInput.GetString());

                    Console.Clear();

                    s.Start();
                    Console.Write("Wheel Spinning");
                    while (s.Elapsed <= TimeSpan.FromSeconds(time))
                    {
                        spinner.Turn(displayMsg: "Wheel spinning ", sequenceCode: 4);
                    }
                    s.Stop();


                }

                Console.Clear();

                int addWinningLosses = 0;
                // This loop will add up all the winning and losing bets
                foreach (var betMoney in ListOfBetResults)
                {
                    addWinningLosses += betMoney;
                }

                if (addWinningLosses > 0)
                {
                    WriteText.WonBet();
                    Console.WriteLine(addWinningLosses);
                }

                if (addWinningLosses < 0)
                {
                    WriteText.LostBet();
                    Console.WriteLine(addWinningLosses);
                }

                if (addWinningLosses.Equals(0))
                {
                    WriteText.BrokeEven();
                    Console.WriteLine(addWinningLosses);
                }

                WriteText.NewCashAmount();
                Console.WriteLine(user.AfterBetCashAmount(addWinningLosses));

                addWinningLosses = 0;
                WriteText.KeepPlaying();
                userDecision = Menu.YesOrNo(UserInput.GetString());

            }


        }

        public static void QuitGame(bool quit)
        {
            if(quit)
            Environment.Exit(0);
        }
       
    }
}
