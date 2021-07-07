using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display title as the C# console calculator app.
            Console.WriteLine("Deck of Cards Simulator in C#\r");
            Console.WriteLine("-----------------------------\n");
            string choice = "";

            // Ask the user to choose an option.
            do {
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\tn - Get a new deck");
                Console.WriteLine("\ts - Shuffle the current deck");
                Console.WriteLine("\td - Draw top card from deck");
                Console.WriteLine("\tr - See rest of cards in deck");
                Console.WriteLine("\tq - Quit");
                Console.Write("What would you like to do? ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "n":
                        //new deck
                        Console.WriteLine("you chose a");
                        break;
                    case "s":
                        //shuffle
                        Console.WriteLine("you chose s");
                        break;
                    case "d":
                        //draw card
                        Console.WriteLine("you chose m");
                        break;
                    case "r":
                        //see rest of cards
                        Console.WriteLine("you chose d");
                        break;
                }
            } while (choice != "q");
            //Card testCard = new Card(Rank.Eight, Suit.Hearts);
            //Console.WriteLine(testCard.ToString());
            Deck testDeck = new Deck();
        
            testDeck.drawCard();
            testDeck.drawCard();
            testDeck.drawCard();
            foreach (Card card in testDeck.cards) {
                Console.WriteLine(card.ToString());
            }
            Console.WriteLine("...");
            testDeck.shuffle();
            foreach (Card card in testDeck.cards) {
                Console.WriteLine(card.ToString());
            }
            
        }
    }
}
