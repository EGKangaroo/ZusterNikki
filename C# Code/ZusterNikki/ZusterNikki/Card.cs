using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZusterNikki
{
    class Card
    {
        //fields
        int cardNumber;
        int pairedCard;
        bool flipped;
        bool pairFound;
        string model;

        //properties
        public int CardNumber
        {
            get { return this.cardNumber; }
        }

        public int PairedCard
        {
            get { return this.pairedCard; }
        }

        public bool Flipped
        {
            get { return this.flipped; }
        }

        public bool PairFound
        {
            get { return this.pairFound; }
        }

        public string Model
        {
            get { return this.model; }
        }

        //constructor
        public Card(int cardNumber, int pairedCard, string model)
        {
            this.cardNumber = cardNumber;
            this.pairedCard = pairedCard;
            this.flipped = false;
            this.pairFound = false;
            this.model = model;
        }

        //methods
        public void Flip()
        {
            if (!this.flipped)
            {
                this.flipped = true;
            }
            else
            {
                this.flipped = false;
            }
        }

        public void LockPairFound()
        {
            this.pairFound = true;
        }

        public override string ToString()
        {
            string toString = Convert.ToString(cardNumber) + ", " + Convert.ToString(pairedCard) + ", " + model;
            return toString;
        }
    }
}
