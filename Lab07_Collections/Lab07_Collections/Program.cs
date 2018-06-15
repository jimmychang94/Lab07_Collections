using System;
using Lab07_Collections.Classes;

namespace Lab07_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestRemove();

        }

        /// <summary>
        /// This method creates and then tests the removal method in the deck collection.
        /// </summary>
        static void TestRemove()
        {
            Deck<Card> deck = CreateHeartDeck();
            Console.WriteLine(deck.DetermineLength());
            deck.Remove(0);
            // Once Remove is run once the whole index shifts so this is like popping an item out of an array.
            deck.Remove(0);
            deck.Remove(0);
            deck.Remove(0);
            deck.Remove(0);
            PrintDeck(deck);
            Console.WriteLine(deck.DetermineLength());
        }

        /// <summary>
        /// This method tests the shuffle method in the deck collection.
        /// </summary>
        static void TestShuffle()
        {
            Deck<Card> deck = CreateFullDeck();
            PrintDeck(deck);
            deck.Shuffle();
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine("-Shuffled Deck-");
            Console.WriteLine("--------------");
            Console.WriteLine();
            PrintDeck(deck);
        }

        /// <summary>
        /// This method creates a deck with numbers from 2 to 10 and Ace, King, Queen, Jack all in the Heart suite.
        /// </summary>
        /// <returns>The deck of all numbers with only the heart suite</returns>
        public static Deck<Card> CreateHeartDeck()
        {
            Deck<Card> deckOfCards = new Deck<Card>();
            Card AceHeart = new Card(Number.Ace, Suites.Hearts);
            Card TwoHeart = new Card(Number.Two, Suites.Hearts);
            Card ThreeHeart = new Card(Number.Three, Suites.Hearts);
            Card FourHeart = new Card(Number.Four, Suites.Hearts);
            Card FiveHeart = new Card(Number.Five, Suites.Hearts);
            Card SixHeart = new Card(Number.Six, Suites.Hearts);
            Card SevenHeart = new Card(Number.Seven, Suites.Hearts);
            Card EightHeart = new Card(Number.Eight, Suites.Hearts);
            Card NineHeart = new Card(Number.Nine, Suites.Hearts);
            Card TenHeart = new Card(Number.Ten, Suites.Hearts);
            Card JackHeart = new Card(Number.Jack, Suites.Hearts);
            Card QueenHeart = new Card(Number.Queen, Suites.Hearts);
            Card KingHeart = new Card(Number.King, Suites.Hearts);
            deckOfCards.Add(AceHeart);
            deckOfCards.Add(TwoHeart);
            deckOfCards.Add(ThreeHeart);
            deckOfCards.Add(FourHeart);
            deckOfCards.Add(FiveHeart);
            deckOfCards.Add(SixHeart);
            deckOfCards.Add(SevenHeart);
            deckOfCards.Add(EightHeart);
            deckOfCards.Add(NineHeart);
            deckOfCards.Add(TenHeart);
            deckOfCards.Add(JackHeart);
            deckOfCards.Add(QueenHeart);
            deckOfCards.Add(KingHeart);
            return deckOfCards;
        }

        /// <summary>
        /// This method creates a deck of 52 cards, all 13 numbers in all 4 suites.
        /// </summary>
        /// <returns>The deck that was created</returns>
        public static Deck<Card> CreateFullDeck()
        {
            Deck<Card> deckOfCards = new Deck<Card>();
            Card AceHeart = new Card(Number.Ace, Suites.Hearts);
            Card TwoHeart = new Card(Number.Two, Suites.Hearts);
            Card ThreeHeart = new Card(Number.Three, Suites.Hearts);
            Card FourHeart = new Card(Number.Four, Suites.Hearts);
            Card FiveHeart = new Card(Number.Five, Suites.Hearts);
            Card SixHeart = new Card(Number.Six, Suites.Hearts);
            Card SevenHeart = new Card(Number.Seven, Suites.Hearts);
            Card EightHeart = new Card(Number.Eight, Suites.Hearts);
            Card NineHeart = new Card(Number.Nine, Suites.Hearts);
            Card TenHeart = new Card(Number.Ten, Suites.Hearts);
            Card JackHeart = new Card(Number.Jack, Suites.Hearts);
            Card QueenHeart = new Card(Number.Queen, Suites.Hearts);
            Card KingHeart = new Card(Number.King, Suites.Hearts);
            Card AceDiamond = new Card(Number.Ace, Suites.Diamonds);
            Card TwoDiamond = new Card(Number.Two, Suites.Diamonds);
            Card ThreeDiamond = new Card(Number.Three, Suites.Diamonds);
            Card FourDiamond = new Card(Number.Four, Suites.Diamonds);
            Card FiveDiamond = new Card(Number.Five, Suites.Diamonds);
            Card SixDiamond = new Card(Number.Six, Suites.Diamonds);
            Card SevenDiamond = new Card(Number.Seven, Suites.Diamonds);
            Card EightDiamond = new Card(Number.Eight, Suites.Diamonds);
            Card NineDiamond = new Card(Number.Nine, Suites.Diamonds);
            Card TenDiamond = new Card(Number.Ten, Suites.Diamonds);
            Card JackDiamond = new Card(Number.Jack, Suites.Diamonds);
            Card QueenDiamond = new Card(Number.Queen, Suites.Diamonds);
            Card KingDiamond = new Card(Number.King, Suites.Diamonds);
            Card AceClub = new Card(Number.Ace, Suites.Clubs);
            Card TwoClub = new Card(Number.Two, Suites.Clubs);
            Card ThreeClub = new Card(Number.Three, Suites.Clubs);
            Card FourClub = new Card(Number.Four, Suites.Clubs);
            Card FiveClub = new Card(Number.Five, Suites.Clubs);
            Card SixClub = new Card(Number.Six, Suites.Clubs);
            Card SevenClub = new Card(Number.Seven, Suites.Clubs);
            Card EightClub = new Card(Number.Eight, Suites.Clubs);
            Card NineClub = new Card(Number.Nine, Suites.Clubs);
            Card TenClub = new Card(Number.Ten, Suites.Clubs);
            Card JackClub = new Card(Number.Jack, Suites.Clubs);
            Card QueenClub = new Card(Number.Queen, Suites.Clubs);
            Card KingClub = new Card(Number.King, Suites.Clubs);
            Card AceSpades = new Card(Number.Ace, Suites.Spades);
            Card TwoSpades = new Card(Number.Two, Suites.Spades);
            Card ThreeSpades = new Card(Number.Three, Suites.Spades);
            Card FourSpades = new Card(Number.Four, Suites.Spades);
            Card FiveSpades = new Card(Number.Five, Suites.Spades);
            Card SixSpades = new Card(Number.Six, Suites.Spades);
            Card SevenSpades = new Card(Number.Seven, Suites.Spades);
            Card EightSpades = new Card(Number.Eight, Suites.Spades);
            Card NineSpades = new Card(Number.Nine, Suites.Spades);
            Card TenSpades = new Card(Number.Ten, Suites.Spades);
            Card JackSpades = new Card(Number.Jack, Suites.Spades);
            Card QueenSpades = new Card(Number.Queen, Suites.Spades);
            Card KingSpades = new Card(Number.King, Suites.Spades);

            deckOfCards.Add(AceHeart);
            deckOfCards.Add(TwoHeart);
            deckOfCards.Add(ThreeHeart);
            deckOfCards.Add(FourHeart);
            deckOfCards.Add(FiveHeart);
            deckOfCards.Add(SixHeart);
            deckOfCards.Add(SevenHeart);
            deckOfCards.Add(EightHeart);
            deckOfCards.Add(NineHeart);
            deckOfCards.Add(TenHeart);
            deckOfCards.Add(JackHeart);
            deckOfCards.Add(QueenHeart);
            deckOfCards.Add(KingHeart);
            deckOfCards.Add(AceDiamond);
            deckOfCards.Add(TwoDiamond);
            deckOfCards.Add(ThreeDiamond);
            deckOfCards.Add(FourDiamond);
            deckOfCards.Add(FiveDiamond);
            deckOfCards.Add(SixDiamond);
            deckOfCards.Add(SevenDiamond);
            deckOfCards.Add(EightDiamond);
            deckOfCards.Add(NineDiamond);
            deckOfCards.Add(TenDiamond);
            deckOfCards.Add(JackDiamond);
            deckOfCards.Add(QueenDiamond);
            deckOfCards.Add(KingDiamond);
            deckOfCards.Add(AceClub);
            deckOfCards.Add(TwoClub);
            deckOfCards.Add(ThreeClub);
            deckOfCards.Add(FourClub);
            deckOfCards.Add(FiveClub);
            deckOfCards.Add(SixClub);
            deckOfCards.Add(SevenClub);
            deckOfCards.Add(EightClub);
            deckOfCards.Add(NineClub);
            deckOfCards.Add(TenClub);
            deckOfCards.Add(JackClub);
            deckOfCards.Add(QueenClub);
            deckOfCards.Add(KingClub);
            deckOfCards.Add(AceSpades);
            deckOfCards.Add(TwoSpades);
            deckOfCards.Add(ThreeSpades);
            deckOfCards.Add(FourSpades);
            deckOfCards.Add(FiveSpades);
            deckOfCards.Add(SixSpades);
            deckOfCards.Add(SevenSpades);
            deckOfCards.Add(EightSpades);
            deckOfCards.Add(NineSpades);
            deckOfCards.Add(TenSpades);
            deckOfCards.Add(JackSpades);
            deckOfCards.Add(QueenSpades);
            deckOfCards.Add(KingSpades);
            return deckOfCards;
        }
        
        /// <summary>
        /// This method prints the deck provided to the console.
        /// </summary>
        /// <param name="deck">The deck to print</param>
        static void PrintDeck (Deck<Card> deck)
        {
            foreach(Card card in deck)
            {
                Console.WriteLine($"{card.CardSuite}: {card.CardNumber}");
            }
        }
    }
}
