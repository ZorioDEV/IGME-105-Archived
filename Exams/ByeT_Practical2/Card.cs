using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByeT_Practical2
{
    /// <summary>
    /// Card of the Minions
    /// </summary>
    internal class Card
    {
        // *** FIELDS ***
        private string name;
        private int cost;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-ONLY property of name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }
        /// <summary>
        /// Read-ONLY property of cost.
        /// </summary>
        public int Cost
        {
            get
            {
                return cost;
            }
        }

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Main constructor for Card.
        /// </summary>
        /// <param name="name">Name of Card</param>
        /// <param name="cost">Cost amount of Card</param>
        public Card(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        // *** METHODS ***
        /// <summary>
        /// Prints out the stats of the Card.
        /// </summary>
        /// <returns>Name & Stats of Card</returns>
        public override string ToString()
        {
            return $"{name} Stats: {cost} cost";
        }
        /// <summary>
        /// Plays the Minion card into the game.
        /// </summary>
        public virtual void Cast()
        {
            Console.WriteLine($"{name} is cast");
        }
    }
}
