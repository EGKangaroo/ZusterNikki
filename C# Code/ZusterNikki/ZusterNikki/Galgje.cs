using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZusterNikki
{
    class Galgje
    {
        //fields
        private Woord word;
        private string revealedWord;
        private int guessesLeft;
        private List<string> wrongGuesses;
        private List<string> allGuesses;
        private bool win;

        //properties
        public Woord Word
        {
            get { return this.word; }
        }

        public string RevealedWord
        {
            get { return this.revealedWord; }
        }

        public int GuessesLeft
        {
            get { return this.guessesLeft; }
        }

        public List<string> WrongGuesses
        {
            get { return this.wrongGuesses; }
        }

        public List<string> AllGuesses
        {
            get { return this.allGuesses; }
        }

        public bool Win
        {
            get { return this.win; }
        }

        //constructors
        public Galgje()
        {
            this.word = new Woord();
            string revealedWord = "";

            foreach (var character in Word.RevealedLetters)
            {
                revealedWord = revealedWord + character.ToString() + " ";
            }

            this.revealedWord = revealedWord;
            this.guessesLeft = 10;
            this.wrongGuesses = new List<string>();
            this.allGuesses = new List<string>();
            this.win = false;
        }

        //methods

        //guess function
        public void Guess(string letter, Player player)
        {
            bool alreadyGuessed = CheckAlreadyGuessed(letter);
            string newRevealedWord = "";
            if (alreadyGuessed == false)
            {
                allGuesses.Add(letter);
                bool correctGuess = Word.CheckGuess(letter);
                if(correctGuess == false)
                {
                    wrongGuesses.Add(letter);
                    guessesLeft--;
                }
            }
            foreach(var character in Word.RevealedLetters)
            {
                newRevealedWord = newRevealedWord + character.ToString() + " ";
            }
            revealedWord = newRevealedWord;
            checkWin(player);
        }

        //checks whether a letter has already been guessed
        public bool CheckAlreadyGuessed(string letter)
        {
            bool alreadyGuessed = false;

            foreach (var guess in allGuesses)
            {
                if (guess == letter)
                {
                    alreadyGuessed = true;
                }
            }
            return alreadyGuessed;
        }

        //checks whether the word has been fully guessed
        private void checkWin(Player player)
        {
            if(Word.Letters.SequenceEqual(Word.RevealedLetters))
            {
                win = true;
                AddScore(player);
            }
        }

        private void AddScore(Player player)
        {
            player.ReceiveScore(10);
        }
    }
}
