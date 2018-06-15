using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Card
    {
        /// <summary>
        /// This holds the number for this card
        /// </summary>
        public Number CardNumber { get; set; }
        
        /// <summary>
        /// This holds the suite for this card
        /// </summary>
        public Suites CardSuite { get; set; }

        /// <summary>
        /// This constructor makes sure a card has a number and a suite
        /// </summary>
        /// <param name="cardNumber">The enum of a number</param>
        /// <param name="suite">The enum of a suite</param>
        public Card(Number cardNumber, Suites suite)
        {
            CardNumber = cardNumber;
            CardSuite = suite;
        }
    }

    /// <summary>
    /// This enum makes it so there are only 4 suites
    /// </summary>
    public enum Suites
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    /// <summary>
    /// This enum makes it so that there are only 13 numbers
    /// </summary>
    public enum Number
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
}
