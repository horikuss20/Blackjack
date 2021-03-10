using System;
using System.Collections.Generic;
using System.Text;
using static ClassLibrary1.Program;

namespace ClassLibrary1
{
    public class Factory
    {

        public static ICard CreateCard(CardFace face, CardSuit suit)
        {
            ICard card;

            card = new ClassLibrary1.Card(face, suit);

            return card;
        }

        public static ICard CreateBlackjackCard(CardFace face, CardSuit suit)
        {
            ICard card;

            card = new BlackjackCard(face, suit);

            return card;
        }
    }
}
