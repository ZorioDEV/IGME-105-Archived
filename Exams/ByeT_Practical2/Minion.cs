using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByeT_Practical2
{
    /// <summary>
    /// Minion Stats And Actions of Card
    /// </summary>
    internal class Minion : Card
    {
        // *** FIELDS ***
        private int attack;
        private int health;
        private string subtype;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-ONLY property of attack.
        /// </summary>
        public int Attack
        {
            get
            {
                return attack;
            }
        }
        /// <summary>
        /// Read-ONLY property of health.
        /// </summary>
        public int Health
        {
            get
            {
                return Health;
            }
        }
        /// <summary>
        /// Read-ONLY property of subtype.
        /// </summary>
        public string Subtype
        {
            get
            {
                return subtype;
            }
        }
        /// <summary>
        /// Read-ONLY boolean property that tests if alive based on if health is above zero.
        /// </summary>
        public bool Alive
        {
            get
            {
                if(health > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Minion constructor if there is no subtype.
        /// </summary>
        /// <param name="name">Name of Minion</param>
        /// <param name="cost">Cost amount of Minion</param>
        /// <param name="attack">Attack amount of Minion</param>
        /// <param name="health">Health amount of Minion</param>
        public Minion(string name, int cost, int attack, int health) 
                    : base (name, cost)
        {
            this.attack = attack;
            this.health = health;
        }
        /// <summary>
        /// Minion constructor if there is a subtype.
        /// </summary>
        /// <param name="name">Name of Minion</param>
        /// <param name="cost">Cost amount of Minion</param>
        /// <param name="attack">Attack amount of Minion</param>
        /// <param name="health">Health amount of Minion</param>
        /// <param name="subtype">Subtype name of Minion</param>
        public Minion(string name, int cost, int attack, int health, string subtype)
                    : base(name, cost)
        {
            this.attack = attack;
            this.health = health;
            this.subtype = subtype;
        }

        // *** METHODS ***
        /// <summary>
        /// Prints out the stats of the Minion.
        /// Tests if minion is alive and if there is a subtype.
        /// </summary>
        /// <returns>Info & Stats of Minion</returns>
        public override string ToString()
        {
            // tests if Minion is alive or dead
            string status;
            if (Alive == true)
            {
                status = "Alive";
            }
            else
            {
                status = "Dead";
            }

            // prints out subtype if possible
            string extra = "";
            if(subtype != null)
            {
                extra = $"Subtype: {subtype}. ";
            }

            // returns data & stats
            return base.ToString() + $" / " +
                $"{attack} attack / " +
                $"{health} health. " +
                $"{extra}" +
                $"Status: {status}.";
        }

        /// <summary>
        /// Plays the Minion card into the game.
        /// </summary>
        public override void Cast()
        {
            Console.WriteLine($"{Name} enters play!");
        }

        /// <summary>
        /// Reduces the health of the Minion by damage taken.
        /// </summary>
        /// <param name="amount">Amount of Damage</param>
        public void TakeDamage(int amount)
        {
            // makes sure the damage take is always positive
            if(amount >= 0)
            {
                health -= amount;
            }
            else
            {
                health -= -amount;
            }

            // prints out the Minion's attack stat
            Console.WriteLine($"{Name} attacks for {attack} damage.");
        }
    }
}
