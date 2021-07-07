using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card testCard = new Card(Rank.Eight, Suit.Hearts);
            Console.WriteLine(testCard.ToString());
        }
    }
}
