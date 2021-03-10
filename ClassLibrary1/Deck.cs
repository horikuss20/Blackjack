using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClassLibrary1.Program;

namespace ClassLibrary1
{
    public class Deck
    {
        public List<ICard> _cards;
        public Deck()
        {
            _cards = new List<ICard>();
            CreateDeck();
        }

        public ICard Deal()
        {
            ICard topcard = new ClassLibrary1.Card(CardFace.Ace,CardSuit.Clubs);
            if (_cards.Count == 0)
            {
                CreateDeck();
                ShuffleDeck();
            }
            topcard = _cards[0];
            _cards.RemoveAt(0);
            return topcard;
        }

        public void CreateDeck()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardFace face in Enum.GetValues(typeof(CardFace)))
                {
                    _cards.Add(Factory.CreateBlackjackCard(face, suit)); //changed to add blackjack card
                }
            }
        }

        public void ShuffleDeck()
        {
            _cards = _cards.OrderBy(i => Guid.NewGuid()).ToList();
        }
    }
}
