using System;
using System.Collections.Generic;

namespace cards
{
    class Deck
    {
        //This will create the deck of cards
        public List<Card> cards;
        public string[] cardVals = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        public string[] suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };

        public void newDeck()
        {
            this.cards = new List<Card> { };
            Console.WriteLine($"Deck Created");
            if (this.cards.Count > 0)
            {
                this.cards.Clear();
            }
            int count = 0;
            foreach (string v in this.cardVals)
            {
                count++;
                foreach (string s in this.suits)
                {
                    cards.Add(new Card(v, s, count));
                }
            }
            int total = cards.Count;
            Console.WriteLine($"Deck of {total} Created!");
        }
        public void printDeck()
        {
            foreach (Card card in cards)
            {
                card.Print();
            }
        }

        public void ShuffleDeck()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                Card temp = cards[i];
                int randvalue = rand.Next(0, cards.Count);
                cards[i] = cards[randvalue];
                cards[randvalue] = temp;
            }
        }

        public void Deal()
        {
            this.cards.RemoveAt(0);
        }
    }
}