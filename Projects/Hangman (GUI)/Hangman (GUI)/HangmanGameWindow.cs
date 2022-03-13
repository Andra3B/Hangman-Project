using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hangman;

namespace Hangman__GUI_
{
    public partial class HangmanGameWindow : Form
    {
        public HangmanGameWindow()
        {
            InitializeComponent();
        }

        public void UpdateInterface(HangmanGame gameState)
        {
            lblAttempts.Text = $"Attempt: {gameState.CurrentAttempt}/{gameState.MaximumAttempts}";
            lblFragmentedWord.Text = string.Join(" ",gameState.WordFragments);
            lblGuessedLetters.Text = $"Guessed Letters: [{string.Join(",",gameState.GuessedLetters.ToArray())}]";
        }
    }
}
