using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public enum GameState : byte
    {
        Won = 0,
        Lost,
        Dead,
        Started
    }

    public sealed class HangmanGame
    {
        private uint _maximumAttempts;
        private uint _currentAttempt;
        private string _word;
        private StringBuilder _wordFragments;
        private HashSet<char> _guessedLetters;
        public GameState State;

        public uint MaximumAttempts { get => _maximumAttempts; set => _maximumAttempts = (State == GameState.Started) ? _maximumAttempts : value; }
        public uint CurrentAttempt { get => _currentAttempt; set => _currentAttempt = (State == GameState.Started) ? _currentAttempt : value; }
        public string Word { get => _word; set => _word = (State == GameState.Started) ? _word : value.ToUpper(); }
        public char[] GuessedLetters { get => _guessedLetters.ToArray(); }
        public char[] WordFragments { get => _wordFragments.ToString().ToArray(); }

        public static readonly char UNKNOWN_CHARACTER = '_';

        public HangmanGame(uint maximumAttempts, string word)
        {
            MaximumAttempts = maximumAttempts;
            _word = word.ToUpper();
            _guessedLetters = new HashSet<char>();
            State = GameState.Dead;
        }

        public HangmanGame()
        {
            MaximumAttempts = 1;
            _guessedLetters = new HashSet<char>();
            State = GameState.Dead;
        }

        public void Start()
        {
            if (State == GameState.Started)
                return;

            _currentAttempt = 1;
            State = GameState.Started;
            _wordFragments = new StringBuilder(new string(UNKNOWN_CHARACTER, _word.Length), 0, _word.Length, _word.Length);
            _guessedLetters.Clear();
        }

        public void Quit()
        {
            if (State == GameState.Dead)
                return;

            State = GameState.Dead;
        }

        public uint CheckGuess(char guessLetter, bool updateState)
        {
            guessLetter = guessLetter.ToString().ToUpper()[0];

            if (State == GameState.Dead)
                throw new InvalidOperationException("Use Hangman.Start() in order to use this method!");

            uint count = 0;

            for (int index = 0; index < _word.Length; index++)
            {
                _guessedLetters.Add(guessLetter);

                if (guessLetter == _word[index])
                {
                    _wordFragments[index] = _word[index];
                    count++;
                }
            }

            if (updateState)
            {
                _currentAttempt++;
                UpdateState();
            }

            return count;
        }

        public override string ToString()
        {
            return $"Attempt: [{_currentAttempt}/{_maximumAttempts}] |=| {_wordFragments.ToString()} |=| Letters Guessed: [{string.Join(",", _guessedLetters.ToArray())}]";
        }

        private void UpdateState()
        {
            if (_currentAttempt <= _maximumAttempts)
            {
                if (!_wordFragments.ToString().Contains('_')) { State = GameState.Won; }
            }
            else { State = GameState.Lost; }
        }
    }
}