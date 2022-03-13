using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hangman;
using Hangman.Utilities;

namespace Hangman__GUI_
{
    internal static class Program
    {
        private static Form activeForm;

        public static void ToggleActiveWindow(Form form)
        {
            if(activeForm != null)
                activeForm.Hide();

            activeForm = form;
            activeForm.Show();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            const string WORD_BANK_PATH = @"..\..\..\..\WordBanks";
            HangmanGame game = new HangmanGame();

            HangmanMainMenu hangmanMainMenu = new HangmanMainMenu();
            HangmanOptionMenu hangmanOptionMenu = new HangmanOptionMenu();
            HangmanGameWindow hangmanGameWindow = new HangmanGameWindow();

            hangmanOptionMenu.FormClosing += (_, args) => { args.Cancel = true; ToggleActiveWindow(hangmanMainMenu); };
            hangmanGameWindow.FormClosing += (_, args) => 
            { 
                args.Cancel = true;
                if (MessageBox.Show(
                    "Are you sure you want to quit?",
                    "You are about to quit",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    game.Quit();
                    ToggleActiveWindow(hangmanMainMenu);
                }
            };

            hangmanMainMenu.btnPlay.Click += (_, __) =>
            {
                game.Word = Utilities.GetRandomStringFromFile($@"{WORD_BANK_PATH}\WordBank.txt");
                Console.WriteLine((uint)(game.Word.Length + (10 - hangmanOptionMenu.tbDifficultySlider.Value)));
                game.MaximumAttempts = (uint)(game.Word.Length + (10 - hangmanOptionMenu.tbDifficultySlider.Value));

                game.Start();

                hangmanGameWindow.UpdateInterface(game);
                ToggleActiveWindow(hangmanGameWindow);
            };

            hangmanGameWindow.btnSubmit.Click += (_, __) => 
            {

                char letter = hangmanGameWindow.txtLetterInput.Text.PadRight(1, ' ').ToUpper()[0];
                hangmanGameWindow.txtLetterInput.Clear();
                hangmanGameWindow.txtLetterInput.Focus();

                if (letter != ' ' && !game.GuessedLetters.Contains(letter))
                    game.CheckGuess(letter, true);
                
                if (game.State != GameState.Started)
                {
                    if (game.State == GameState.Lost)
                        MessageBox.Show($"The word was {game.Word}", "You lost!", MessageBoxButtons.OK);
                    else
                        MessageBox.Show($"The word was {game.Word} and it took you {game.CurrentAttempt} attempt/s", "You won!", MessageBoxButtons.OK);

                    ToggleActiveWindow(hangmanMainMenu);
                }

                hangmanGameWindow.UpdateInterface(game);
            };

            hangmanMainMenu.btnOption.Click += (_, __) => ToggleActiveWindow(hangmanOptionMenu);

            activeForm = hangmanMainMenu;
            Application.Run(hangmanMainMenu);
        }
    }
}
