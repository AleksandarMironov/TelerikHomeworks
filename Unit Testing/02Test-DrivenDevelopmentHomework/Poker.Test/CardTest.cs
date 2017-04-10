using System;
using NUnit.Framework;

namespace Poker.Test
{
    [TestFixture]
    public class CardTest
    {
        [Test]
        [TestCase(CardFace.Ace, CardSuit.Diamonds, "A♦")]
        [TestCase(CardFace.King, CardSuit.Diamonds, "K♦")]
        [TestCase(CardFace.Queen, CardSuit.Diamonds, "Q♦")]
        [TestCase(CardFace.Jack, CardSuit.Diamonds, "J♦")]
        [TestCase(CardFace.Ten, CardSuit.Diamonds, "10♦")]
        [TestCase(CardFace.Nine, CardSuit.Diamonds, "9♦")]
        [TestCase(CardFace.Eight, CardSuit.Diamonds, "8♦")]
        [TestCase(CardFace.Seven, CardSuit.Diamonds, "7♦")]
        [TestCase(CardFace.Six, CardSuit.Diamonds, "6♦")]
        [TestCase(CardFace.Five, CardSuit.Diamonds, "5♦")]
        [TestCase(CardFace.Four, CardSuit.Diamonds, "4♦")]
        [TestCase(CardFace.Three, CardSuit.Diamonds, "3♦")]
        [TestCase(CardFace.Two, CardSuit.Diamonds, "2♦")]

        [TestCase(CardFace.Ace, CardSuit.Spades, "A♠")]
        [TestCase(CardFace.King, CardSuit.Spades, "K♠")]
        [TestCase(CardFace.Queen, CardSuit.Spades, "Q♠")]
        [TestCase(CardFace.Jack, CardSuit.Spades, "J♠")]
        [TestCase(CardFace.Ten, CardSuit.Spades, "10♠")]
        [TestCase(CardFace.Nine, CardSuit.Spades, "9♠")]
        [TestCase(CardFace.Eight, CardSuit.Spades, "8♠")]
        [TestCase(CardFace.Seven, CardSuit.Spades, "7♠")]
        [TestCase(CardFace.Six, CardSuit.Spades, "6♠")]
        [TestCase(CardFace.Five, CardSuit.Spades, "5♠")]
        [TestCase(CardFace.Four, CardSuit.Spades, "4♠")]
        [TestCase(CardFace.Three, CardSuit.Spades, "3♠")]
        [TestCase(CardFace.Two, CardSuit.Spades, "2♠")]

        [TestCase(CardFace.Ace, CardSuit.Hearts, "A♥")]
        [TestCase(CardFace.King, CardSuit.Hearts, "K♥")]
        [TestCase(CardFace.Queen, CardSuit.Hearts, "Q♥")]
        [TestCase(CardFace.Jack, CardSuit.Hearts, "J♥")]
        [TestCase(CardFace.Ten, CardSuit.Hearts, "10♥")]
        [TestCase(CardFace.Nine, CardSuit.Hearts, "9♥")]
        [TestCase(CardFace.Eight, CardSuit.Hearts, "8♥")]
        [TestCase(CardFace.Seven, CardSuit.Hearts, "7♥")]
        [TestCase(CardFace.Six, CardSuit.Hearts, "6♥")]
        [TestCase(CardFace.Five, CardSuit.Hearts, "5♥")]
        [TestCase(CardFace.Four, CardSuit.Hearts, "4♥")]
        [TestCase(CardFace.Three, CardSuit.Hearts, "3♥")]
        [TestCase(CardFace.Two, CardSuit.Hearts, "2♥")]

        [TestCase(CardFace.Ace, CardSuit.Clubs, "A♣")]
        [TestCase(CardFace.King, CardSuit.Clubs, "K♣")]
        [TestCase(CardFace.Queen, CardSuit.Clubs, "Q♣")]
        [TestCase(CardFace.Jack, CardSuit.Clubs, "J♣")]
        [TestCase(CardFace.Ten, CardSuit.Clubs, "10♣")]
        [TestCase(CardFace.Nine, CardSuit.Clubs, "9♣")]
        [TestCase(CardFace.Eight, CardSuit.Clubs, "8♣")]
        [TestCase(CardFace.Seven, CardSuit.Clubs, "7♣")]
        [TestCase(CardFace.Six, CardSuit.Clubs, "6♣")]
        [TestCase(CardFace.Five, CardSuit.Clubs, "5♣")]
        [TestCase(CardFace.Four, CardSuit.Clubs, "4♣")]
        [TestCase(CardFace.Three, CardSuit.Clubs, "3♣")]
        [TestCase(CardFace.Two, CardSuit.Clubs, "2♣")]


        public void ToStringTesting_ShouldPrintCorrecrtString(CardFace face, CardSuit suit, string expected)
        {
            var card = new Card(face, suit);

            Assert.AreEqual(expected, card.ToString());
        }
    }
}
