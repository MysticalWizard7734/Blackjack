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
        Random rand;

        List<KeyValuePair<string, int>> cards;

        public int numberOfDecks;

        public Karty(int numberOfDecks){
            this.numberOfDecks = numberOfDecks;
            rand = new Random();
            cards = new List<KeyValuePair<string, int>>();

            generateDeck(numberOfDecks);
        }

        public KeyValuePair<string, int> pullCard()
        {
            if (cards.Count <= 0) generateDeck(numberOfDecks);

            int cisloKarty = rand.Next(cards.Count);

            KeyValuePair<string, int> karta = cards.ElementAt(cisloKarty);

            cards.Remove(cards.Find(k => k.Key == karta.Key));

            return karta;
        }

        void generateDeck(int numberOfDecks)
        {
            System.Console.Write($"Premiešavanie {numberOfDecks} balíčkov kariet");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.WriteLine(".");

            for(int i = 0; i < numberOfDecks; i++){
                string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
                string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
                Dictionary<string, int> cardValues = new Dictionary<string, int>()
                {
                    { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 },
                    { "7", 7 }, { "8", 8 }, { "9", 9 }, { "10", 10 }, { "Jack", 10 },
                    { "Queen", 10 }, { "King", 10 }, { "Ace", 11 }
                };

                foreach (var suit in suits)
                {
                    foreach (var value in values)
                    {
                        string cardName = $"{value} of {suit}";
                        int cardValue = cardValues[value];
                        cards.Add(new KeyValuePair<string, int>(cardName, cardValue));
                    }
                }
            }
        }
    }
}
