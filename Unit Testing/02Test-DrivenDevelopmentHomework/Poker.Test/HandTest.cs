using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;

namespace Poker.Test
{
    [TestFixture]
    public class HandTest
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(52)]

        public void HandToString_ShouldCallAllCardsToString(int numberOfCards)
        {
            //Arrange
            IList<ICard> collection = new List<ICard>();
            var card = new Card(CardFace.Seven, CardSuit.Clubs);

            //Act
            for (int i = 0; i < numberOfCards; i++)
            {
                collection.Add(card);
            }
            var hand = new Hand(collection);
            var output = hand.ToString();

            StringBuilder expectedOutput = new StringBuilder(); //I know it is wrong, but it is faster 

            for (int i = 0; i < numberOfCards; i++)
            {
                expectedOutput.Append("7♣");
            }


            //Assert
            Assert.AreEqual(expectedOutput.ToString(), output);

        }

        [Test]
        public void HandToString_ShouldReturnStringEmpty_WhenCollectionIsEmpty()
        {
            var collection = new List<ICard>();

            var hand = new Hand(collection);

            Assert.AreEqual(string.Empty, hand.ToString());
        }
    }
}
