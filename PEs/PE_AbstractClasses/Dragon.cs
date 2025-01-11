using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_AbstractClasses
{
    public class Dragon : Monster
    {
        // *** FIELDS ***
        string resistanceType;

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Main constructor to initialize Dragon's data.
        /// </summary>
        /// <param name="name">Name of the Dragon</param>
        /// <param name="health">Health of the Dragon</param>
        /// <param name="attackType">Special Ability of the Dragon</param>
        /// <param name="resistanceType">Special Ability the Dragon's Resistant To</param>
        public Dragon(string name, int health, string attackType, string resistanceType)
            : base(name, health, attackType)
        {
            this.resistanceType = resistanceType;
        }

        // *** METHODS ***
        /// <summary>
        /// Attacks a specified Monster target.
        /// </summary>
        /// <param name="target">Name of Monster target</param>
        public override void Attack(Monster target)
        {
            // randomly generates an attack amount between 10-20
            randomGenerator = new Random();
            int randomAttack = randomGenerator.Next(10, 21);
            Console.Write($"{Name} attacks for {randomAttack} {AttackType} damage. ");

            // makes the Dragon attack a targeted Monster
            target.TakeDamage(randomAttack, AttackType);
        }

        /// <summary>
        /// Recieved damage from other Monster & tests if the Dragon is resistant.
        /// </summary>
        /// <param name="amount">Damage Amount</param>
        /// <param name="attackType">Special Ability of the Attacking Monster</param>
        public override void TakeDamage(int amount, string attackType)
        {
            int damage = amount;
            string type = attackType;

            // test if the Dragon is resistant
            if (type == resistanceType)
            {
                // reduces the damage taken by half
                damage = (int)Math.Floor(damage / 2.0);
                Console.WriteLine($"{Name} takes {amount} {type} damage, halved to " +
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
        /// Prints out the Dragon's full data using base Monster information.
        /// </summary>
        /// <returns>String of the dragons's info</returns>
        public override string ToString()
        {
            return $"The Dragon {base.ToString()} {Name} is resistant to {resistanceType} damage.";
        }
    }
}
