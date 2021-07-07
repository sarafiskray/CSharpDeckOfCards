using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {

        
        public List<Card> cards {get; set;}
        //I considered using a Stack to represent the cards
        //would have made it easy to see the top card
        //but harder to shuffle

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
            Card topCard = cards[cards.Count - 1];
            cards.Remove(topCard);
            Console.WriteLine(topCard.ToString());
            return topCard;
        }


    }
}
