using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Deck
    {
        private Card[] deck;
        private int dealtCard;
        private const int numberOfCards = 52;
        private Random ran;
        public Deck()
        {
            double[] faceValue = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "J", "Q", "K" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

            
            deck = new Card[numberOfCards];
            dealtCard = 0;
            ran = new Random();
            for (int count = 0; count <deck.Length; count++)
            {
                deck[count] = new Card(faceValue[count / 13], suits[count / 13]);
            }

        }

        public void Shuffle()
        {
            dealtCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = ran.Next(numberOfCards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
                int third = ran.Next(numberOfCards);
                temp = deck[second];
                deck[second] = deck[third];
                deck[third] = temp;
                int fourth = ran.Next(numberOfCards);
                temp = deck[third];
                deck[third] = deck[fourth];
                deck[fourth] = temp;
                int fifth = ran.Next(numberOfCards);
                temp = deck[fourth];
                deck[fourth] = deck[fifth];
                deck[fifth] = temp;
            }
        }

        public Card DealCard()
        {
            if (dealtCard < deck.Length)
            {
                return deck[dealtCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
