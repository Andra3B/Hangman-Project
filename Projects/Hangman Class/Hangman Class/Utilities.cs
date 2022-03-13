using System;
using System.IO;

namespace Hangman.Utilities
{
    public static class Utilities
    {
        private static Random _randomGenerator = new Random();

        public static string GetRandomStringFromFile(string path)
        {
            using (StreamReader wordBank = new StreamReader(path))
            {
                string[] temp = wordBank.ReadToEnd().Split('\n');
                return temp[_randomGenerator.Next(0, temp.Length - 1)].Trim();
            }
        }
    }
}