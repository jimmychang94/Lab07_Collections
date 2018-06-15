using System;
using Xunit;
using Lab07_Collections;
using Lab07_Collections.Classes;

namespace Lab07CollectionsUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddingACardToTheDeckTest()
        {
            // Arrange
            Deck<Card> deck = Program.CreateHeartDeck();
            Card card = new Card(Number.Ace, Suites.Spades);

            // Act
            deck.Add(card);
            
            // Assert
            Assert.True(deck.Length() == 14);
        }

        [Fact]
        public void RemovingACardFromTheDeckThatDoesExistTest()
        {
            // Arrange
            Deck<Card> deck = Program.CreateHeartDeck();

            // Act
            bool removed = deck.Remove(0);

            // Assert
            Assert.True(removed);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(200)]
        [InlineData(20)]
        public void RemovingACardFromTheDeckThatDoesNotExistTest(int index)
        {
            // Arrange
            Deck<Card> deck = Program.CreateHeartDeck();

            // Act
            bool removed = deck.Remove(index);

            // Assert
            Assert.False(removed);
        }

        [Fact]
        public void CardsCanBeShuffledTest()
        {
            // Arrange
            Deck<Card> deck = Program.CreateFullDeck();

            // Act
            Card card1 = deck.Find(0);
            deck.Shuffle();
            Card card2 = deck.Find(0);

            // Assert
            Assert.NotEqual(card1, card2);
        }

        [Fact]
        public void GettersAndSettersOfMyPropertiesFromMyCardClassTest()
        {
            // Arrange and Act
            Card card = new Card(Number.Ace, Suites.Spades);

            // Assert
            Assert.Equal(Number.Ace, card.CardNumber);
            Assert.Equal(Suites.Spades, card.CardSuite);
        }
    }
}
