﻿using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Poker.Test
{
    [TestFixture]
    public class TestHandChecker
    {
        private static PokerHandsChecker pokerChecker = new PokerHandsChecker();
        [Test]
        public void TestHandChecker_PassNot5Cards_ShouldReturnFalse()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cards);
            var valid = pokerChecker.IsValidHand(hand);
            Assert.IsFalse(valid);
        }

        [Test]
        public void TestHandChecker_PassNull_ShouldThrow()
        {
            TestDelegate test = () => pokerChecker.IsValidHand(null);
            Assert.Throws(typeof(ArgumentNullException), test);
        }

        [Test]
        public void TestHandChecker_PassTwoSameCards_ShouldReturnFalse()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                 new Card(CardFace.Five, CardSuit.Clubs),
                  new Card(CardFace.Six, CardSuit.Clubs),
                   new Card(CardFace.Eight, CardSuit.Clubs),
                    new Card(CardFace.Nine, CardSuit.Clubs)
            };
            var hand = new Hand(cards);
            var valid = pokerChecker.IsValidHand(hand);
            Assert.IsFalse(valid);
        }

        [Test]
        public void TestHandChecker_PassValidCards_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                 new Card(CardFace.Four, CardSuit.Clubs),
                  new Card(CardFace.Six, CardSuit.Clubs),
                   new Card(CardFace.Eight, CardSuit.Clubs),
                    new Card(CardFace.Nine, CardSuit.Clubs)
            };
            var hand = new Hand(cards);
            var valid = pokerChecker.IsValidHand(hand);
            Assert.IsTrue(valid);
        }

        [Test]
        public void TestHandChecker_PassFourCards_ShouldThrow()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                 new Card(CardFace.Four, CardSuit.Clubs),
                  new Card(CardFace.Six, CardSuit.Clubs),
                   new Card(CardFace.Eight, CardSuit.Clubs),
            };
            var hand = new Hand(cards);
            TestDelegate test = () => pokerChecker.IsFlush(hand);
            Assert.Throws(typeof(ArgumentException), test);
        }

        [Test]
        public void TestHandChecker_PassValidFlush_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                 new Card(CardFace.Four, CardSuit.Clubs),
                  new Card(CardFace.Six, CardSuit.Clubs),
                   new Card(CardFace.Eight, CardSuit.Clubs),
                   new Card(CardFace.Queen,CardSuit.Clubs)
            };
            var hand = new Hand(cards);
            Assert.IsTrue(pokerChecker.IsFlush(hand));
        }

        [Test]
        public void TestHandChecker_PassValidFourOfKind_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                 new Card(CardFace.Five, CardSuit.Clubs),
                  new Card(CardFace.Five, CardSuit.Hearts),
                   new Card(CardFace.Four, CardSuit.Spades),
                   new Card(CardFace.Five,CardSuit.Spades)
            };
            var hand = new Hand(cards);
            Assert.IsTrue(pokerChecker.IsFourOfAKind(hand));
        }

        [Test]
        public void TestHandChecker_PassValidThreeOfKind_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                 new Card(CardFace.Five, CardSuit.Clubs),
                  new Card(CardFace.Queen, CardSuit.Hearts),
                   new Card(CardFace.Six, CardSuit.Spades),
                   new Card(CardFace.Five,CardSuit.Hearts)
            };
            var hand = new Hand(cards);
            Assert.IsTrue(pokerChecker.IsThreeOfAKind(hand));
        }

        [Test]
        public void TestHandChecker_PassValidFullHouse_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                 new Card(CardFace.Five, CardSuit.Clubs),
                  new Card(CardFace.Five, CardSuit.Hearts),
                   new Card(CardFace.Six, CardSuit.Spades),
                   new Card(CardFace.Six,CardSuit.Clubs)
            };
            var hand = new Hand(cards);
            Assert.IsTrue(pokerChecker.IsFullHouse(hand));
        }

        [Test]
        public void TestHandChecker_PassValidPair_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                 new Card(CardFace.Five, CardSuit.Clubs),
                  new Card(CardFace.Seven, CardSuit.Hearts),
                   new Card(CardFace.Queen, CardSuit.Spades),
                   new Card(CardFace.Seven,CardSuit.Clubs)
            };
            var hand = new Hand(cards);
            Assert.IsTrue(pokerChecker.IsOnePair(hand));
        }

        [Test]
        public void TestHandChecker_PassValidTwoPair_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                 new Card(CardFace.Queen, CardSuit.Clubs),
                  new Card(CardFace.Seven, CardSuit.Hearts),
                   new Card(CardFace.Queen, CardSuit.Spades),
                   new Card(CardFace.Seven,CardSuit.Clubs)
            };
            var hand = new Hand(cards);
            Assert.IsTrue(pokerChecker.IsTwoPair(hand));
        }

        [Test]
        public void TestHandChecker_PassValidStraight_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                   new Card(CardFace.Nine, CardSuit.Spades),
                   new Card(CardFace.Ten,CardSuit.Clubs)
            };
            var hand = new Hand(cards);
            Assert.IsTrue(pokerChecker.IsStraight(hand));
        }

        [Test]
        public void TestHandChecker_PassValidStraightFlush_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Diamonds),
                   new Card(CardFace.Nine, CardSuit.Diamonds),
                   new Card(CardFace.Ten,CardSuit.Diamonds)
            };
            var hand = new Hand(cards);
            Assert.IsTrue(pokerChecker.IsStraightFlush(hand));
        }

        [Test]
        public void TestHandChecker_PassValidHighCard_ShouldReturnTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Two, CardSuit.Spades),
                   new Card(CardFace.Nine, CardSuit.Diamonds),
                   new Card(CardFace.Ten,CardSuit.Diamonds)
            };
            var hand = new Hand(cards);
            Assert.IsTrue(pokerChecker.IsHighCard(hand));
        }

        [Test]
        public void TestHandChecker_PassSamePowerHands_SHouldReturnZero()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Two, CardSuit.Spades),
                   new Card(CardFace.Nine, CardSuit.Diamonds),
                   new Card(CardFace.Ten,CardSuit.Diamonds)
            };
            var hand = new Hand(cards);
            Assert.AreEqual(0, pokerChecker.CompareHands(hand, hand));
        }

        [Test]
        public void TestHandChecker_PassBiggerHand_SHouldReturnOne()
        {
            IList<ICard> cards1 = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Diamonds),
                   new Card(CardFace.Nine, CardSuit.Diamonds),
                   new Card(CardFace.Ten,CardSuit.Diamonds)
            };
            var hand1 = new Hand(cards1);
            IList<ICard> cards2 = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                   new Card(CardFace.Nine, CardSuit.Diamonds),
                   new Card(CardFace.Ten,CardSuit.Diamonds)
            };
            var hand2 = new Hand(cards2);
            Assert.AreEqual(1, pokerChecker.CompareHands(hand1, hand2));
        }

        [Test]
        public void TestHandChecker_PassSmallerHand_SHouldReturnMinusOne()
        {
            IList<ICard> cards1 = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Spades),
                   new Card(CardFace.Nine, CardSuit.Diamonds),
                   new Card(CardFace.Ten,CardSuit.Diamonds)
            };
            var hand1 = new Hand(cards1);
            IList<ICard> cards2 = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Eight, CardSuit.Diamonds),
                   new Card(CardFace.Nine, CardSuit.Diamonds),
                   new Card(CardFace.Ten,CardSuit.Diamonds)
            };
            var hand2 = new Hand(cards2);
            Assert.AreEqual(-1, pokerChecker.CompareHands(hand1, hand2));
        }

        [Test]
        public void TestHandChecker_PassBiggerHighCard_SHouldReturnOne()
        {
            IList<ICard> cards1 = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Two, CardSuit.Spades),
                   new Card(CardFace.Nine, CardSuit.Diamonds),
                   new Card(CardFace.Ten,CardSuit.Diamonds)
            };
            var hand1 = new Hand(cards1);
            IList<ICard> cards2 = new List<ICard>
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                 new Card(CardFace.Seven, CardSuit.Diamonds),
                  new Card(CardFace.Three, CardSuit.Diamonds),
                   new Card(CardFace.Nine, CardSuit.Spades),
                   new Card(CardFace.Ten,CardSuit.Diamonds)
            };
            var hand2 = new Hand(cards2);
            Assert.AreEqual(1, pokerChecker.CompareHands(hand1, hand2));
        }
    }
}

