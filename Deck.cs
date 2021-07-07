using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {

        
        public List<Card> cards {get;}
        //List is ordered and resizes dynamically
        //Stack would be nice for drawing card, but overall List makes more sense
        

        public Deck() {
            //I considered using Enum.GetValues() to loop through the suits and ranks.
            Suit[] suits = new Suit[] {Suit.Diamonds, Suit.Clubs, Suit.Hearts, Suit.Spades};
            Rank[] ranks = new Rank[] {Rank.Ace, Rank.Two, Rank.Three, Rank.Four, Rank.Five, 
            Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.Jack, Rank.Queen, Rank.King};

            List<Card> theseCards = new List<Card>();

            foreach (Suit suit in suits) {
                foreach(Rank rank in ranks) {
                    theseCards.Add(new Card(rank, suit));
                }
            }

            cards = theseCards;
        }

        public Card drawCard() {
            //I chose index cards.Count - 1 instead of 0
            //to represent the top of the deck
            Card topCard = cards[cards.Count - 1];
            cards.Remove(topCard);
            Console.WriteLine(topCard.ToString());
            return topCard;
        }

        //I decided to use random so we get a different deck each time
        //additionally, I wanted to do it in one pass for optimal efficiency
        public void shuffle() {
            Random rand = new Random();
            for (int i = 0; i < cards.Count - 1; i++) {
                int randIndex = rand.Next(i, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randIndex];
                cards[randIndex] = temp;
            }
        }

        public List<Card> showRestOfDeck() {
            return cards;
        }


    }
}
