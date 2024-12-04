using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Hrac
    {
        public int score { get; private set; } = 0;

        public string state { get; private set; } = "playing";

        public bool hasAce { get; private set; } = false;

        public void addScore(int cardValue)
        {
            if (cardValue == 11)
            {
                if (hasAce) 
                {
                    cardValue = 1;
                }
                hasAce = true;
            }

            score += cardValue;

            if (score > 21) state = "lost";
            else if (score < 21) state = "playing";
            else if (score == 21) state = "won";
        }

        public void stand()
        {
            state = "stand";
        }
    }
}
