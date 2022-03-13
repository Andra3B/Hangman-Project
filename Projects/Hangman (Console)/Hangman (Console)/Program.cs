using System;
using Hangman;
using Hangman.Utilities;

class Program
{
    public static void StyledOutput(string message, ConsoleColor colour)
    {
        Console.ForegroundColor = colour;
        Console.Write($"\n\t{message}\n\n");
        Console.ResetColor();
    }

    public static int DisplayMenu(
        string title,
        params (string OptionName, ConsoleKey OptionKey)[] options)
    {
        Console.Clear();
        while (true)
        {
            string output = $"{title}\n";
            for(int index = 0; index < options.Length; index++) 
            { 
                output += $"| {options[index].OptionName} [{options[index].OptionKey}] |";
            }

            Console.WriteLine(output);

            var keyPressed = Console.ReadKey(true).Key;

            for (int index = 0; index < options.Length; index++)
            {
                if (options[index].OptionKey == keyPressed)
                    return index;
            }

            StyledOutput(
                $"'{keyPressed}' is not a valid option!", 
                ConsoleColor.Red);
        }
    }

    public static void Main(string[] args)
    {
        const string WORD_BANK_PATH = @"..\..\..\..\..\WordBanks";

        HangmanGame game = new();
        byte gameDifficulty = 0;

        while (true)
        {
            Start:;
            switch (DisplayMenu(
                "Hangman:",
                ("Play", ConsoleKey.P),
                ("Options", ConsoleKey.O),
                ("Quit", ConsoleKey.Q)))
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("|== OPTION_NAME (CURRENT_VALUE) [RANGE] {DESCRIPTION} ==|\n");

                    byte difficultyTemp;
                    while (true)
                    {
                        Console.Write(
                            $"Difficulty ({gameDifficulty}) [0-10] {{Reduces the number of attempts}}: ");

                        if (!byte.TryParse(Console.ReadLine(), out difficultyTemp))
                            StyledOutput("Invalid difficulty set!", ConsoleColor.Red);
                        else
                            gameDifficulty = Math.Clamp(difficultyTemp,(byte)0,(byte)10);
                        break;
                    }

                    goto Start;

                case 2:
                    goto End;
            }

            game.Word = Utilities.GetRandomStringFromFile($@"{WORD_BANK_PATH}\WordBank.txt");
            game.MaximumAttempts = (uint)(game.Word.Length + (10 - gameDifficulty));

            Console.Clear();

            game.Start();
            while (game.State == GameState.Started)
            {
                Console.Clear();

                Console.Write($"{game}\nEnter your guess: ");
                char letter = Console.ReadLine().PadRight(1, ' ').ToUpper()[0];

                if (letter == ' ')
                {
                    switch(DisplayMenu("Are you sure you want to quit:", ("Yes", ConsoleKey.Y), ("No", ConsoleKey.N)))
                    {
                        case 0:
                            game.Quit();
                            goto Start;
                    }
                } else if (!game.GuessedLetters.Contains(letter))
                    game.CheckGuess(letter,true);
            }

            Console.Clear();

            if (game.State == GameState.Won)
                StyledOutput($"\tYou Won!\nThe word was {game.Word} and it took your {game.CurrentAttempt} attempt/s.", ConsoleColor.Green);
            else
                StyledOutput($"You Lost!\n   The word was {game.Word}.", ConsoleColor.Red);

            Console.ReadKey();
        }

        End:;
    }
}