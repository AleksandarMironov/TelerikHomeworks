﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder outputString = new StringBuilder();
            foreach (var card in this.Cards)
            {
                outputString.Append(card.ToString());
            }

            return outputString.ToString();
        }
    }
}
