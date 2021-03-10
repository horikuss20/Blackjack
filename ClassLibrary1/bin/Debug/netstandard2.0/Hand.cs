using System;
using System.Collections.Generic;
using System.Text;
using static ClassLibrary1.Program;

namespace ClassLibrary1
{
    public class Hand
    {
        protected List<ICard> _cards = new List<ICard>();

        public virtual void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        public virtual void Draw(int x, int y)
        {
            foreach(var card in _cards)
            {
                x += 10;
                card.Draw(x, y);
            }
        }
    }
}
        
    

