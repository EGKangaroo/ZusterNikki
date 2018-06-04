using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZusterNikki
{
    public enum Difficulty
    {
        easy = 8,
        medium = 12,
        hard = 16
    }
    class MemoryGameHandler
    {
        //fields
        private static Random rnd = new Random();
        private int[] orderCards;
        private Card[] cards;
        private static string[] models = new string[8] 
        {
            "Gloves.png",
            "IV.png",
            "Pills.png",
            "Stethoscope.png",
            "Suitcase.png",
            "Plaster.png",
            "Syringe.png",
            "Temperature.png"
        };
        private Difficulty gameTileNumber;
        private bool won;

        //properties
        public Card[] Cards
        {
            get { return this.cards; }
        }

        public bool Won
        {
            get { return this.won; }
        }

        //constructor
        public MemoryGameHandler(Difficulty selectedDifficulty)
        {
            this.won = false;

            //Define game difficulty
            this.gameTileNumber = selectedDifficulty;

            //determine number of cards in game
            orderCards = new int[(int)gameTileNumber];

            //fill the order with numbers
            for(int i = 0; i < orderCards.Length; i++)
            {
                orderCards[i] = i;
            }

            //shuffle the order
            for (int i = orderCards.Length - 1; i > 0; i--)
            {
                int n = rnd.Next(i + 1);
                int temp = orderCards[i];
                orderCards[i] = orderCards[n];
                orderCards[n] = temp;
            }

            //make paired cards
            cards = new Card[(int)gameTileNumber];
            int j = 0;
            int model = 0;
            for(int i = 0; i < cards.Length; i += 2)
            {
                cards[i] = new Card(orderCards[j], orderCards[j + 1], models[model]);
                cards[i + 1] = new Card(orderCards[j + 1], orderCards[j], models[model]);
                j += 2;
                model++;
            }
            cards = cards.OrderBy(o => o.CardNumber).ToArray();

            foreach(var card in cards)
            {
                Console.WriteLine(card);
            }
        }

        //methods

        //checks if you have won the game
        public void CheckWin(Player player)
        {
            bool won = true;
            foreach(var card in cards)
            {
                if (!card.PairFound)
                {
                    won = false;
                }
            }
            Console.WriteLine(won);

            if (won)
            {
                player.ReceiveScore(20);
            }
            this.won = won;
        }

        //flip a card
        public void FlipCard(Card selectedCard)
        {
            //do not do anything if the card is already flipped
            if (selectedCard.Flipped)
            {
                return;
            }
            //you can now safely assume the card isn't yet flipped
            else
            {
                int j = 0;
                //checks how many cards have been flipped so far
                foreach(var card in cards)
                {
                    //looks for flipped cards that had not had their pair found yet
                    if (card.Flipped && !card.PairFound)
                    {
                        j++;
                    }
                }

                //if less than two cards have been flipped you are allowed to flip
                if(j < 2)
                {
                    selectedCard.Flip();
                }
                else
                {
                    //otherwise nothing
                }
            }
        }

        public void UnflipCards()
        {
            foreach(var card in cards)
            {
                if(card.Flipped && !card.PairFound)
                {
                    card.Flip();
                }
            }
        }

        //checks for a pair and returns a bool
        public bool CheckPair(Card selectedCard)
        {
            bool pairFound = false;
            if (cards[selectedCard.PairedCard].Flipped)
            {
                pairFound = true;
                Console.WriteLine("pair found between {0}, and {1}", selectedCard, cards[selectedCard.PairedCard]);
            }
            return pairFound;
        }

        //locks both the selected card as well as the paired card as pair found
        public void Score(Card selectedCard, Player player)
        {
            //check if you have flipped two cards
            int j = 0;
            foreach(var card in cards)
            {
                if (card.Flipped && !card.PairFound)
                {
                    j++;
                }
            }
            //if two cards flipped, check for a pair and score if pair is found
            if(j == 2)
            {
                bool pairFound = CheckPair(selectedCard);
                if (pairFound)
                {
                    selectedCard.LockPairFound();
                    cards[selectedCard.PairedCard].LockPairFound();

                    CheckWin(player);
                }
            }
        }
    }
}
