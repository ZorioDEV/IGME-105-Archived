using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByeT_HW6
{
    internal class CommonCharacter
    {
        // *** FEILDS ***
        protected string name;
        protected int health;
        protected int level;
        protected Random random;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-only property of the character's name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }
        /// <summary>
        /// Read-only property of the character's health.
        /// </summary>
        public int Health
        {
            get
            {
                return health;
            }
        }
        /// <summary>
        /// Read-only property of the character's level.
        /// </summary>
        public int Level
        {
            get
            {
                return level;
            }
        }
        /// <summary>
        /// Read-only property of the character's death status.
        /// </summary>
        public bool IsDead
        {
            get
            {
                if(health <= 0)
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
        /// Main constructor to initialize the characters attributes.
        /// </summary>
        /// <param name="name">The character's name.</param>
        /// <param name="health">The character's health.</param>
        /// <param name="level">The character's level.</param>
        /// <param name="random">Random number generator.</param>
        public CommonCharacter(string name, int health, int level, Random random)
        {
            this.name = name;
            this.health = health;
            this.level = level;
            this.random = random;
        }

        // *** METHODS ***
        /// <summary>
        /// Randomly selects damage amount based on level.
        /// </summary>
        /// <returns>Integer amount of damage given.</returns>
        public virtual int Attack()
        {
            return random.Next(1, level + 1);
        }

        /// <summary>
        /// Subtracts certain amount of damage from the character's health.
        /// </summary>
        /// <param name="amount">Integer amount of damage taken.</param>
        public virtual void TakeDamage(int amount)
        {
            health -= amount;

            if (health < 0)
            {
                health = 0;
            }
        }

        /// <summary>
        /// Tells user if character can run away.
        /// </summary>
        /// <returns>True or False.</returns>
        public virtual bool ReadyToFlee()
        {
            if (health < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Prints data about character.
        /// </summary>
        /// <returns>String of the character's data.</returns>
        public override string ToString()
        {
            return $"{name} is level {level} and has {health} health left.";
        }

    }
}
