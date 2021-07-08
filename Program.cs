using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        //Deck currDeck;
        static void Main(string[] args)
        {
            //newlines and tabs for formatting
            Console.WriteLine("\n\tDeck of Cards Simulator in C#\r");
            Console.WriteLine("\t-----------------------------\n");

            string choice = "";
            Deck currDeck = new Deck();

            do {
                Console.WriteLine("\nInput a letter to pick an action:\n");
                Console.WriteLine("\tn - Get a new deck");
                Console.WriteLine("\ts - Shuffle the current deck");
                Console.WriteLine("\tm - Get a new deck and shuffle it");
                Console.WriteLine("\td - Draw top card from current deck");
                Console.WriteLine("\tr - See rest of cards in current deck");
                Console.WriteLine("\tw - Play simple game of war");
                Console.WriteLine("\tq - Quit\n");
                Console.Write("What would you like to do? ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "n":
                        //new deck
                        currDeck = new Deck();
                        Console.WriteLine("\nA new deck has been created! It has not been shuffled.");
                        break;
                    case "s":
                        //shuffle
                        currDeck.shuffle();
                        Console.WriteLine("\nYou shuffled the deck!");
                        break;
                    case "m":
                        currDeck = new Deck();
                        currDeck.shuffle();
                        Console.WriteLine("\nA new deck has been created and shuffled!");
                        break;
                    case "d":
                        //draw card
                        Card top = currDeck.drawCard();
                        Console.WriteLine("\nYou drew the " + top.ToString() + ".");
                        break;
                    case "r":
                        //see rest of cards
                        Console.WriteLine("\nHere are the rest of the cards in the deck:\n");
                        foreach (Card card in currDeck.cards) {
                            Console.WriteLine(card.ToString());
                        }
                        //Console.WriteLine("\n");
                        break;
                    case "w":
                        currDeck.simpleWar();
                        break;
                    case "q":
                        break;
                    default:
                        Console.WriteLine("\nPlease choose one of the given options.");
                        break;
                }
            } while (choice != "q");
            
            Console.WriteLine("\nThanks for playing!");
            
            
            
            
        }
    }
}
