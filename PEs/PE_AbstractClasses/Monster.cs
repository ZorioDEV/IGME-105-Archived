using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_AbstractClasses
{
    public abstract class Monster
    {
        // *** FIELDS ***
        string name;
        int health;
        string attackType;
        public Random randomGenerator;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-Only Property of Name Field
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Get & Set Block of Health Field
        /// </summary>
        public int Health
        {
            get
            {
                return health;
            }
            // sets health to zero if negative
            set
            {
                if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }

        /// <summary>
        /// Read-Only Property of AttackType Feild
        /// </summary>
        public string AttackType
        {
            get
            {
                return attackType;
            }
        }

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Main constructor to initialize Monster's data.
        /// </summary>
        /// <param name="name">Name of the Monster</param>
        /// <param name="health">Health of the Monster</param>
        /// <param name="attackType">Special Ability of the Monster</param>
        public Monster(string name, int health, string attackType)
        {
            this.name = name;
            this.health = health;
            this.attackType = attackType;
        }

        // *** METHODS ***
        /// <summary>
        /// Attacks a specified Monster target.
        /// </summary>
        /// <param name="target">Name of Monster target</param>
        public abstract void Attack(Monster target);

        /// <summary>
        /// Recieved damage from other Monster & accounts for the special ability type.
        /// </summary>
        /// <param name="amount">Damage Amount</param>
        /// <param name="attackType">Special Ability of the Attacking Monster</param>
        public abstract void TakeDamage(int amount, string attackType);

        /// <summary>
        /// Tests which special ability the Monster has & prints out the Monster's info.
        /// </summary>
        /// <returns>String of the monster's info</returns>
        public override string ToString()
        {
            string ability;

            // assigns a certain action to the monster's ability type
            switch (attackType)
            {
                case "fire":
                    ability = "breath fire";
                    break;
                case "cold":
                    ability = "freezes enemies";
                    break;
                case "poison":
                    ability = "spreads venom";
                    break;
                case "electricity":
                    ability = "strikes with lightning";
                    break;
                // if not one of the 4 abilities
                default:
                    ability = "has an unknown power";
                    break;
            }

            // prints out the monster's info
            return $"{Name} has {Health} health and {ability}.";
        }
    }
}
