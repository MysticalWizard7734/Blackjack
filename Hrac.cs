using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Hrac
    {
        public int money;

        public int score { get; private set; } = 0;

        public string state { get; private set; } = "playing";

        public int numberOfAces { get; private set; } = 0;

        public int cardsPulled { get; private set; } = 0;

        public void addScore(int cardValue)
        {
            if (cardValue == 11)
            {
                //if player gets ace, we store it in a variable
                numberOfAces++;
            }

            score += cardValue;

            if (score > 21 && numberOfAces > 0)
            {
                //if player busts and has an ace we substract 10 to count the ace as 1 not 11
                //we than substract 1 from numberOfAces so we dont substract 10 more than once for each players ace
                score -= 10;
                numberOfAces--;
            }

            if (score > 21) state = "lost";
            else if (score < 21) state = "playing";
            else if (score == 21 && cardsPulled == 2) state = "blackjack";
            else if (score == 21) state = "stand";
        }

        public Hrac(int money)
        {
            this.money = money;
        }

        public void Stand()
        {
            state = "stand";
        }

        public void evaluateGame(string dealerState, int dealerScore, int bet){
            if(state == "lost"){            
                System.Console.WriteLine("Hrac prehral");
            }
            else if (score == 21 && state != "blackjack" && dealerState == "blackjack"){
                System.Console.WriteLine("Hrac prehral");
            }
            else if (state == "stand" && (dealerState == "lost" || (dealerScore - score < 0))){
                System.Console.WriteLine("Hrac ziskava 2 nasobok vkladu");
                money = money + (bet * 2);
            }
            else if(state == "blackjack" && dealerState != "blackjack"){
                System.Console.WriteLine("Hrac ziskava 2,5 nasobok vkladu");
                money = money + (int)(bet * 2.5);
            }
            else {
                System.Console.WriteLine("Remíza");
                money = money + bet; //push
            }
            score = 0;
            cardsPulled = 0;
            numberOfAces = 0;
        }
    }
}
