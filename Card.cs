using System;
using System.Collections.Generic;

namespace cards
{

    public class Card 
    {
        //Things to describe the class
        public string name;
        public string suit;
        public int val;
        // Below is the constructor

        public Card(string n, string s, int v)
        {
            name = n;
            suit = s;
            val = v;
        }
        //This will help print the card
        public void Print()
        {
            Console.WriteLine($"Your card is {name} of {suit}, number {val}");
        }
    }
}