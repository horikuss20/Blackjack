using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class BlackjackHand : Hand
    {
        public int Score { get; set; }
        bool IsDealer { get;set; }

        List<BlackjackCard> _bjcards = new List<BlackjackCard>();

        public BlackjackHand(bool isDealer = false)
        {
            IsDealer = isDealer;
        }

        public override void Draw(int x, int y)
        {
            Program.ICard facedown;     

            if (IsDealer)
            {
                facedown = _cards[0];
                _cards.RemoveAt(0);
                Console.Write(Score);
                Console.CursorLeft = x;
                Console.WriteLine("-------");
                Console.CursorLeft = x;
                Console.WriteLine("|     |");
                Console.CursorLeft = x;
                Console.WriteLine("|     |");
                Console.CursorLeft = x;
                Console.WriteLine("|     |");
                Console.CursorLeft = x;
                Console.WriteLine("-------");
                base.Draw(x, y);
                _cards[0] = facedown;
            }
            else
            {
                Console.Write(Score);
                base.Draw(x, y);
            }

        }

        private void AceCheck()
        {
            foreach (BlackjackCard aceCheck in _cards)
            {
                if (aceCheck.Face == Program.CardFace.Ace && (Score+11) > 21)
                {
                    if(aceCheck.Value == 11)
                    {
                        aceCheck.Value = 1;
                    }
                    
                }
                else if(aceCheck.Face == Program.CardFace.Ace && (Score + 11 <21))
                {
                    if (aceCheck.Value == 1)
                    {
                        aceCheck.Value = 11;
                    }
                }


            }
        }
        public override void AddCard(Program.ICard card)
        {
            base.AddCard(card);
            BlackjackCard _bCard;
            _bCard = (BlackjackCard) card;
            _bjcards.Add(_bCard);
            Score = 0;
            foreach(var bjcard in _bjcards)
            {
                AceCheck();
                Score += bjcard.Value;
            }
        }
    }
}
