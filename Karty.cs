using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Karty
    {
        Random rand = new Random();

        Dictionary<string, int> cards = new Dictionary<string, int> { };

        public KeyValuePair<string, int> pullCard()
        {
            if (cards.Count <= 0) generateDeck();

            int cisloKarty = rand.Next(cards.Count);

            KeyValuePair<string, int> karta = cards.ElementAt(cisloKarty);

            cards.Remove(karta.Key);

            return karta;
        }

        void generateDeck()
        {
            cards.Add("2 of Spades", 2);
            cards.Add("3 of Spades", 3);
            cards.Add("4 of Spades", 4);
            cards.Add("5 of Spades", 5);
            cards.Add("6 of Spades", 6);
            cards.Add("7 of Spades", 7);
            cards.Add("8 of Spades", 8);
            cards.Add("9 of Spades", 9);
            cards.Add("10 of Spades", 10);
            cards.Add("Jack of Spades", 10);
            cards.Add("Queen of Spades", 10);
            cards.Add("King of Spades", 10);
            cards.Add("Ace of Spades", 11);

            cards.Add("2 of Hearts", 2);
            cards.Add("3 of Hearts", 3);
            cards.Add("4 of Hearts", 4);
            cards.Add("5 of Hearts", 5);
            cards.Add("6 of Hearts", 6);
            cards.Add("7 of Hearts", 7);
            cards.Add("8 of Hearts", 8);
            cards.Add("9 of Hearts", 9);
            cards.Add("10 of Hearts", 10);
            cards.Add("Jack of Hearts", 10);
            cards.Add("Queen of Hearts", 10);
            cards.Add("King of Hearts", 10);
            cards.Add("Ace of Hearts", 11);

            cards.Add("2 of Diamonds", 2);
            cards.Add("3 of Diamonds", 3);
            cards.Add("4 of Diamonds", 4);
            cards.Add("5 of Diamonds", 5);
            cards.Add("6 of Diamonds", 6);
            cards.Add("7 of Diamonds", 7);
            cards.Add("8 of Diamonds", 8);
            cards.Add("9 of Diamonds", 9);
            cards.Add("10 of Diamonds", 10);
            cards.Add("Jack of Diamonds", 10);
            cards.Add("Queen of Diamonds", 10);
            cards.Add("King of Diamonds", 10);
            cards.Add("Ace of Diamonds", 11);

            cards.Add("2 of Clubs", 2);
            cards.Add("3 of Clubs", 3);
            cards.Add("4 of Clubs", 4);
            cards.Add("5 of Clubs", 5);
            cards.Add("6 of Clubs", 6);
            cards.Add("7 of Clubs", 7);
            cards.Add("8 of Clubs", 8);
            cards.Add("9 of Clubs", 9);
            cards.Add("10 of Clubs", 10);
            cards.Add("Jack of Clubs", 10);
            cards.Add("Queen of Clubs", 10);
            cards.Add("King of Clubs", 10);
            cards.Add("Ace of Clubs", 11);

        }

    }
}
