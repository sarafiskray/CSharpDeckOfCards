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
            //I chose index 0
            //to represent the top of the deck
            Card topCard = cards[0];
            cards.Remove(topCard);
            //Console.WriteLine(topCard.ToString());
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

        //added this for fun
        //automatically shuffles deck
        //cant play if there are less than 18 cards remaining in the deck
        public void simpleWar() {
            if (cards.Count < 18) {
                Console.WriteLine("\nThere must be at least 18 cards in the deck to play!");
                return;
            }
            else {
                Console.WriteLine("\nWelcome to Simple Game of War!");
                Console.WriteLine("\nYou vs. the computer, first to 5 wins.");
                shuffle();
                Console.WriteLine("\nShuffling the deck...\n");
                int playerScore = 0;
                int cpuScore = 0;
                Console.WriteLine("Press enter to begin\n");
                Console.ReadKey();
                do {
                    Card playerCard = drawCard();
                    Card cpuCard = drawCard();

                    Console.WriteLine("Your card is the " + playerCard.ToString() + ".");
                    Console.WriteLine("Computer drew the " + cpuCard.ToString() + ".");
                    
                    int playerVal = (int)playerCard.rank;
                    int cpuVal = (int)cpuCard.rank;

                    if (playerVal > cpuVal) {
                        Console.WriteLine("You win this round!\n");
                        playerScore += 1;
                    }
                    else if (cpuVal > playerVal) {
                        Console.WriteLine("Computer wins this round.\n");
                        cpuScore += 1;
                    }
                    else {
                        int playerSuit = (int)playerCard.suit;
                        int cpuSuit = (int)cpuCard.suit;
                        if (playerSuit > cpuSuit) {
                            Console.WriteLine("You win this round!\n");
                            playerScore += 1;
                        }
                        else {
                            Console.WriteLine("Computer wins this round!\n");
                            cpuScore += 1;
                        }
                    }

                    Console.WriteLine("You: " + playerScore);
                    Console.WriteLine("Computer: " + cpuScore);
                    
                    if (playerScore == 5) {
                        Console.WriteLine("\nYou Win!\n");
                        break;
                    }
                    else if (cpuScore == 5) {
                        Console.WriteLine("\nComputer wins.\n");
                        break;
                    }
                    Console.WriteLine("Press enter for next round\n");
                    Console.ReadKey();

                } while (cpuScore < 5 && playerScore < 5);
            }
        }


    }
}
