using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winner
{
    public class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random ranNum;

        public Deck()
        {
            string[] faces = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
                                "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

            string[] suits = {"Hearts", "Clubs", "Diamonds", "Spades"};
            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            ranNum = new Random();

            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Card(faces[count % 11], suits[count / 13]);
        }

        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = ranNum.Next(NUMBER_OF_CARDS);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card? DealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }


    }
}
