using System;

namespace DeckOfCards
{
    enum Suit
        {
            Diamonds = 0,
            Clubs,
            Hearts,
            Spades
        }

    enum Rank 
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
    class Card
    {

        public Suit suit {get;}
        public Rank rank {get;}
        //getters only

        public Card(Rank cardRank, Suit cardSuit) {
            rank = cardRank;
            suit = cardSuit;
        }

        //ex. "Ace of Hearts"
        public override string ToString() {
            return rank + " of " + suit;
        }


    }
}
