using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.

        //Properties for the cards value, ranging from Two to Ace
        public enum CardValues
        {
            Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8,
            Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13
        }
        //Properties for the Suits of the cards, raning from Clubs to Spades.
        public enum CardSuits
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        //The 'set' methods for these properties could have some validation

        public CardValues Value { get; set; }
        public CardSuits Suit { get; set; }

        public Card(int CardValue, int CardSuit)
        {
            CardValues number = (CardValues)CardValue;
            Value = number;

            CardSuits suitNumber = (CardSuits)CardSuit;
            Suit = suitNumber;
        }
    }
}
