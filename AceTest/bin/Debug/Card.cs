using System;
using System.Collections.Generic;
using System.Text;
using static ClassLibrary1.Program;

namespace ClassLibrary1
{
    public class Program
    {
        public enum CardSuit
        {
            Spades,
            Hearts,
            Clubs,
            Diamonds
        }
        public enum CardFace
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        public interface ICard
        {
            CardFace Face { get; }
            CardSuit Suit { get; }

            void Draw(int x, int y);
        }
    }

    class Card : ICard
    {
        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }
        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
        }

        public void Draw(int x, int y)
        {
            string _suitString = string.Empty;
            if (Suit == CardSuit.Hearts)
            {
                _suitString = "\u2665";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (Suit == CardSuit.Diamonds)
            {
                _suitString = "\u2666";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if( Suit == CardSuit.Clubs)
            {
                _suitString = "\u2663";
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (Suit == CardSuit.Spades)
            {
                _suitString = "\u2660";
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.CursorTop = y;
            switch (Face)
            {
                case CardFace.Ace:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("A      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("   " + _suitString + "   ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      A");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Two:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("2      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + " " + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      2");
                        Console.CursorLeft = x;
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Three:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("3      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      3");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Four:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("4      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + " " + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + " " + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      4");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Five:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("5      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + " " + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("   " + _suitString + "   ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + " " + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      5");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Six:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("6      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      6");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Seven:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("7      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("   " + _suitString + "   ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      7");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Eight:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("8      ");
                        Console.CursorLeft = x;
                        Console.WriteLine(" " + _suitString + _suitString + " " + _suitString + _suitString + " ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine(" " + _suitString + _suitString + " " + _suitString + _suitString + " ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      8");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Nine:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("9      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      9");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Ten:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("10     ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine(" " + _suitString + _suitString + " " + _suitString + _suitString + " ");
                        Console.CursorLeft = x;
                        Console.WriteLine("  " + _suitString + _suitString + _suitString + "  ");
                        Console.CursorLeft = x;
                        Console.WriteLine("     10");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Jack:
                    {

                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("J      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("   " + _suitString + "   ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      J");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.Queen:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("Q      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("   " + _suitString + "   ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      Q");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                case CardFace.King:
                    {
                        Console.CursorLeft = x;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("K      ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("   " + _suitString + "   ");
                        Console.CursorLeft = x;
                        Console.WriteLine("       ");
                        Console.CursorLeft = x;
                        Console.WriteLine("      K");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }

            }

        }
            
    }
}
