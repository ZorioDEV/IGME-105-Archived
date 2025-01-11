using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByeT_HW6
{
    internal class Dragon : CommonCharacter
    {
        // *** FEILDS ***
        private int armor;
        private int bonusDamage;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-only property of the dragon's armor amount.
        /// </summary>
        public int Armor
        {
            get
            {
                return armor;
            }
        }
        /// <summary>
        /// Read-only property of the dragon's bonus damage amount.
        /// </summary>
        public int BonusDamage
        {
            get
            {
                return bonusDamage;
            }
        }

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Main constructor to initialize the dragon's attributes.
        /// </summary>
        /// <param name="name">The dragon's name.</param>
        /// <param name="health">The dragon's health.</param>
        /// <param name="level">The dragon's level.</param>
        /// <param name="armor">The dragon's armor.</param>
        /// <param name="bonusDamage">The dragon's bonus damage amount.</param>
        /// <param name="random">Random number generator.</param>
        public Dragon(string name, int health, int level, int armor, int bonusDamage, Random random)
            : base(name, health, level, random)
        {
            this.armor = armor;
            this.bonusDamage = bonusDamage;
        }

        // *** METHODS ***
        /// <summary>
        /// Dragon will never flee.
        /// </summary>
        /// <returns>Always false.</returns>
        public override bool ReadyToFlee()
        {
            return false;
        }

        /// <summary>
        /// Randomly selects damage amount based on level and bonus damage.
        /// </summary>
        /// <returns>Integer amount of damage given.</returns>
        public override int Attack()
        {
            int damage = random.Next(1, level + 1) + bonusDamage;

            // Console.WriteLine($"{name} attacks with {damage} damage!");
            return damage;
        }

        /// <summary>
        /// Subtracts certain amount of damage from the dragon's health and armor.
        /// </summary>
        /// <param name="amount">Integer amount of damage taken.</param>
        public override void TakeDamage(int amount)
        {
            int reducedDamage = amount - armor;

            if (reducedDamage < 0)
            {
                reducedDamage = 0;
            }

            health -= reducedDamage;
            // Console.WriteLine($"{name} takes {reducedDamage} damage!");
        }

        /// <summary>
        /// Prints data about the dragon.
        /// </summary>
        /// <returns>String of the dragon's data.</returns>
        public override string ToString()
        {
            return $"{base.ToString()} They are a Dragon with {armor} " +
                $"armor and {bonusDamage} bonus damage. \nThe higher the " +
                $"Dragon's level is the more possible damage this Dragon will do. ";
        }
    }
}
