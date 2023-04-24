using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Card
{
        //Base for the Card class.
        //Value: numbers 1 - 13
        private int _value;
        //Suit: numbers 1 - 4
        private int _suit;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value < 1 || value > 13)
                {
                    throw new ArgumentOutOfRangeException("Value must be between 1 and 13.");
                }
                _value = value;
            }
        }
        public int Suit
        {
            get { return _suit; }
            set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentOutOfRangeException("Suit must be between 1 and 4.");
                }
                _suit = value;
            }
        }
        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

}

