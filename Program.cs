using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck d1 = new Deck();
            d1.Deal();
            d1.Deal();
            d1.Deal();
            d1.printDeck();
        }
    }
}
