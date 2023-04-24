using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private List<Card> _cards;
        private Random _random;
        private int _index = 0;
        public Pack()
        {
            //Initialise the card pack here

            _cards = new List<Card>();

            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    _cards.Add(new Card(value, suit));
                }
            }
            _random = new Random();

        }

        public void shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                //Fisher-Yates shuffle
                Random random = new Random();
                for (int i = _cards.Count - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    Card temp = _cards[i];
                    _cards[i] = _cards[j];
                    _cards[j] = temp;
                }
            }
            else if (typeOfShuffle == 2)
            {
                //Riffle shuffle
                List<Card> half1 = new List<Card>();
                List<Card> half2 = new List<Card>();
                int halfSize = _cards.Count / 2;
                half1.AddRange(_cards.GetRange(0, halfSize));
                half2.AddRange(_cards.GetRange(halfSize, halfSize));
                _cards.Clear();
                Random random = new Random();
                while (half1.Count > 0 && half2.Count > 0)
                {
                    if (random.Next(2) == 0)
                    {
                        _cards.Add(half1[0]);
                        half1.RemoveAt(0);
                    }
                    else
                    {
                        _cards.Add(half2[0]);
                        half2.RemoveAt(0);
                    }
                }
                _cards.AddRange(half1);
                _cards.AddRange(half2);
            }
            else
            {
                //No shuffle, do nothing because the cards are already in order
            }

        }
        public Card dealCard()
        {
            //Deals one card
            if (_index >= _cards.Count)
            {
                throw new InvalidOperationException("The pack is empty");
            }
            Card card = _cards[_index];
            _index++;
            return card;
        }

        public List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            if (_index + amount > _cards.Count)
            {
                throw new InvalidOperationException("The pack does not have enough cards");
            }
            List<Card> cards = _cards.GetRange(_index, amount);
            _index += amount;
            return cards;
        }
        public void PrintPack()
        {
            foreach (Card card in _cards)
            {
                Console.WriteLine($"{card.Value}-{card.Suit}");
            }
        }
    }
}
