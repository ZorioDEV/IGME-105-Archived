using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_CardDeck
{
    internal class Card
    {
        // *** FIELDS ***
        private int value;
        private string suit;

        /// <summary>
        /// Base object for all cards.
        /// </summary>
        /// <param name="value">Number of card.</param>
        /// <param name="suit">Name of suit.</param>
        public Card(int value, string suit)
        {
            this.value = value;
            this.suit = suit;
        }

        /// <summary>
        /// Prints out the value and suit of card.
        /// </summary>
        public void PrintCard()
        {
            // for ace card
            if (value == 1)
            {
                Console.WriteLine($"- Ace of {suit}");
            }
            // for all numbered cards
            else if (value < 11)
            {
                Console.WriteLine($"- {value} of {suit}");
            }
            // for jack card
            else if (value == 11)
            {
                Console.WriteLine($"- Jack of {suit}");
            }
            // for queen card
            else if (value == 12)
            {
                Console.WriteLine($"- Queen of {suit}");
            }
            // for king card
            else if (value == 13)
            {
                Console.WriteLine($"- King of {suit}");
            }
            // [IMPOSSIBLE] - shouldn't be able to acheive this result
            else
            {
                Console.WriteLine("[Invalid]");
            }
        }
    }
}
