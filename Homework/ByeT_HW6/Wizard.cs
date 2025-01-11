using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByeT_HW6
{
    internal class Wizard : CommonCharacter
    {
        // *** FEILDS ***
        private int mana;
        private int spellPower;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-only property of the wizard's mana amount.
        /// </summary>
        public int Mana
        {
            get
            {
                return mana;
            }
        }
        /// <summary>
        /// Read-only property of the wizard's spell power amount.
        /// </summary>
        public int SpellPower
        {
            get
            {
                return spellPower;
            }
        }

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Main constructor to initialize the wizard's attributes.
        /// </summary>
        /// <param name="name">The wizard's name.</param>
        /// <param name="health">The wizard's health.</param>
        /// <param name="level">The wizard's level.</param>
        /// <param name="mana">The wizard's mana.</param>
        /// <param name="spellPower">The wizard's spell power.</param>
        /// <param name="random">Random number generator.</param>
        public Wizard(string name, int health, int level, int mana, int spellPower, Random random)
            : base(name, health, level, random)
        {
            this.mana = mana;
            this.spellPower = spellPower;
        }

        // *** METHODS ***
        /// <summary>
        /// Wizard can only flee if mana is below 10 or health below 50.
        /// </summary>
        /// <returns>True or False.</returns>
        public override bool ReadyToFlee()
        {
            if (mana < 10 || base.ReadyToFlee())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Randomly selects damage amount based on spell power and mana amount.
        /// </summary>
        /// <returns>Integer amount of damage given.</returns>
        public override int Attack()
        {
            int damage = random.Next(1, spellPower + 1);

            if (mana > 10)
            {
                damage += 5;
            }

            // Console.WriteLine($"{name} attacks with {damage} damage!");
            return damage;
        }

        /// <summary>
        /// Subtracts certain amount of damage from the wizard's health and mana amount.
        /// </summary>
        /// <param name="amount">Integer amount of damage taken.</param>
        public override void TakeDamage(int amount)
        {
            int reducedDamage = amount;

            if (mana > 5)
            {
                reducedDamage -= 2;
            }

            if (reducedDamage < 0)
            {
                reducedDamage = 0;
            }

            health -= reducedDamage;
            // Console.WriteLine($"{name} takes {reducedDamage} damage!");
        }

        /// <summary>
        /// Prints data about the wizard.
        /// </summary>
        /// <returns>String of the wizard's data.</returns>
        public override string ToString()
        {
            return $"{base.ToString()} They are a Wizard with {mana} mana " +
                $"and {spellPower} spell power. \nWhen their mana is above 5, " +
                $"all recieved damage are reduced by 2. \nThe higher the spell power " +
                $"the higher possible attack damage the Wizard is able to do.";
        }
    }
}
