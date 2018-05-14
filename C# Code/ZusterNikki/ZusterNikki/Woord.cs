using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZusterNikki
{
    class Woord
    {
        //fields
        private Char[] letters;
        private Char[] revealedLetters;

        //properties
        public Char[] Letters
        {
            get { return this.letters; }
        }

        public Char[] RevealedLetters
        {
            get { return this.revealedLetters; }
        }

        //constructors
        public Woord()
        {
            this.letters = ChooseRandomWord();
            string revealedWord = "";

            for(int i = 0; i < letters.Length ; i++)
            {
                revealedWord = revealedWord + "_";
            }
            this.revealedLetters = revealedWord.ToCharArray();
        }

        //methods

        //picks a random word from the text file to be used when constructing a new instance of word
        private Char[] ChooseRandomWord()
        {
            Random chooseWord = new Random();
            FileStream filestream = new FileStream("galgje/WordFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(filestream);
            List<string> allWords = new List<string>();
            string line = reader.ReadLine();

            while(line != null)
            {
                allWords.Add(line);
                line = reader.ReadLine();
            }

            reader.Close();
            string chosenWord = allWords[chooseWord.Next(allWords.Count)];
            Char[] charArray = chosenWord.ToCharArray();
            return charArray;
        }

        //
        public bool CheckGuess(string guess)
        {
            bool correctGuess = false;
            int i = 0;
            foreach(var letter in letters)
            {
                if(letter.ToString() == guess)
                {
                    correctGuess = true;
                    revealedLetters[i] = Convert.ToChar(guess);
                }
                i++;
            }
            return correctGuess;
        }
    }
}
