using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDecks = 4;

            int playerMoney = 1000;

            Random rand = new Random();

            Karty karty = new Karty(numberOfDecks);

            Hrac hrac1 = new Hrac(playerMoney);

            Dealer dealer = new Dealer();

            while (true)
            {
                System.Console.Write("Stávky sa otvárajú: ");
                
                string input = System.Console.ReadLine();

                KeyValuePair<string, int> card;

                int bet;
                if(int.TryParse(input, out bet)){
                    hrac1.money = hrac1.money - bet;
                    System.Console.WriteLine("Hráč si ťahá 2 karty");
                    for(int i = 0; i < 2; i++){
                        card = karty.pullCard();
                        System.Console.WriteLine(card.Key);
                        hrac1.addScore(card.Value);
                    }

                    System.Console.WriteLine("Dealer si ťahá 2 karty");
                    card = karty.pullCard();
                    System.Console.WriteLine(card.Key);
                    dealer.addScore(card.Value);

                    card = karty.pullCard();
                    dealer.addScore(card.Value);

                    while(hrac1.state == "playing")
                    {
                        System.Console.WriteLine($"Hráč má {hrac1.score}, (hit?)(y/N)");
                        input = Console.ReadLine().ToLower();
                        
                        if(input == "y")
                        {
                            card = karty.pullCard();
                            System.Console.WriteLine(card.Key);
                            hrac1.addScore(card.Value);
                        }
                        else hrac1.Stand();
                    }

                    hrac1.evaluateGame(dealer.score, bet);
                }
                else System.Console.WriteLine($"Pane, {input} nie je číslo...");

            }
        }
    }
}
