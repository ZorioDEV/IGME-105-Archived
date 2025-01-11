using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_AbstractClasses
{
    internal class Beholder : Monster
    {
        // *** FIELDS ***
        string vulerableType;

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Main constructor to initialize Beholder's data.
        /// </summary>
        /// <param name="name">Name of the Beholder</param>
        /// <param name="health">Health of the Beholder</param>
        /// <param name="attackType">Special Ability of the Beholder</param>
        /// <param name="vulerableType">Special Ability the Beholder's Vulerable To</param>
        public Beholder(string name, int health, string attackType, string vulerableType)
            : base(name, health, attackType)
        {
            this.vulerableType = vulerableType;
        }

        // *** METHODS ***
        /// <summary>
        /// Attacks a specified Monster target.
        /// </summary>
        /// <param name="target">Name of Monster target</param>
        public override void Attack(Monster target)
        {
            // randomly generates an attack amount between 5-25
            randomGenerator = new Random();
            int randomAttack = randomGenerator.Next(5, 26);
            Console.Write($"{Name} attacks for {randomAttack} {AttackType} damage. ");

            // makes the Beholder attack a targeted Monster
            target.TakeDamage(randomAttack, AttackType);
        }

        /// <summary>
        /// Recieved damage from other Monster & tests if the Beholder is vulerable.
        /// </summary>
        /// <param name="amount">Damage Amount</param>
        /// <param name="attackType">Special Ability of the Attacking Monster</param>
        public override void TakeDamage(int amount, string attackType)
        {
            int damage = amount;
            string type = attackType;

            // test if the Beholder is vulerable
            if (type == vulerableType)
            {
                // increases the damage taken by double
                damage = damage * 2;
                Console.WriteLine($"{Name} takes {amount} {type} damage, doubled to " +
                    $"{damage} due to a {type} resistance.");
            }
            else
            {
                // recieve normal amount of damage
                Console.WriteLine($"{Name} takes {amount} {type} damage.");
            }

            // reduces health by new damage amount
            Health -= damage;
        }

        /// <summary>
        /// Prints out the Beholder's full data using base Monster information.
        /// </summary>
        /// <returns>String of the beholder's info</returns>
        public override string ToString()
        {
            return $"The Beholder {base.ToString()} {Name} is vulnerable to {vulerableType} damage.";
        }
    }
}
