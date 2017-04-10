using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string faceString;
            switch ((int)this.Face)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    faceString = ((int)this.Face).ToString();
                    break;
                case 11:
                    faceString = "J";
                    break;
                case 12:
                    faceString = "Q";
                    break;
                case 13:
                    faceString = "K";
                    break;
                case 14:
                    faceString = "A";
                    break;
                default:
                    throw new ArgumentException("Wrong card face!");
            }

            char suitString;
            switch ((int)this.Suit)
            {
                case 1:
                    suitString = (char)9827;
                    break;
                case 2:
                    suitString = (char)9830;
                    break;
                case 3:
                    suitString = (char)9829;
                    break;
                case 4:
                    suitString = (char)9824;
                    break;
                default:
                    throw new ArgumentException("Wrong card suit!");
            }

            string outputString = faceString + suitString;

            return outputString;
        }
    }
}
