using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{

    class BlackjackCard : Card
    { 
        public int Value { get; set; }
        public BlackjackCard(Program.CardFace face,Program.CardSuit suit) : base(face,suit)
        {
            switch ((face)
)
            {
                case Program.CardFace.Ace:
                    Value = 1;
                    break;
                case Program.CardFace.Two:
                    Value = 2;
                    break;
                case Program.CardFace.Three:
                    Value = 3;
                    break;
                case Program.CardFace.Four:
                    Value = 4;
                    break;
                case Program.CardFace.Five:
                    Value = 5;
                    break;
                case Program.CardFace.Six:
                    Value = 6;
                    break;
                case Program.CardFace.Seven:
                    Value = 7;
                    break;
                case Program.CardFace.Eight:
                    Value = 8;
                    break;
                case Program.CardFace.Nine:
                    Value = 9;
                    break;
                case Program.CardFace.Ten:
                    Value = 10;
                    break;
                case Program.CardFace.Jack:
                    Value = 10;
                    break;
                case Program.CardFace.Queen:
                    Value = 10;
                    break;
                case Program.CardFace.King:
                    Value = 10;
                    break;
            }
        }
    }
}