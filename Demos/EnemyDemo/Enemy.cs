using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyDemo
{
    public enum Weapon
    {
        Sword,
        Axe,
        Dagger
    }

    internal class Enemy
    {
        public string name;
        public int currentHealth;
        public int maxHealth;
        public Weapon enemyWeapon;
        public string[] heldItems;

        /// <summary>
        /// Enemy character with custom name and starting health.
        /// </summary>
        /// <param name="name">name of the enemy</param>
        /// <param name="currentHealth">starting &/or current health</param>
        public Enemy(string name, int currentHealth)
        {
            this.name = name;
            this.currentHealth = currentHealth;

            // All Enemies can be maxed to 100 HP
            maxHealth = 100;

            // Weapon type is dependent on the name length
            int nameLength = name.Length;

            if (nameLength <= 3)                 // 0-3 chars
            {
                enemyWeapon = Weapon.Sword;
            }
            else if (nameLength <= 7)            // 4-7 chars
            {
                enemyWeapon = Weapon.Axe;
            }
            else                                // 8+ chars
            {
                enemyWeapon = Weapon.Dagger;
            }

            // All enemies start with the same 3 items
            heldItems = new string[3] { "rations", "trinket", "trap" };

            // TODO: Write the answer to these 2 questions here, as comments:
            // What type is it – default or parameterized?
            // Parameterized
            // What does this constructor do?
            // Allows for custom health and name with all defautl feilds of the enemy
        }

        /// <summary>
        /// Prints out the enemy's data/information. 
        /// </summary>
        public void PrintEnemy()
        {
            Console.WriteLine($"This enemy {name} has {currentHealth}/{maxHealth} health.");
            Console.WriteLine($"Weapon: {enemyWeapon}");
            Console.Write("Is holding: ");
            for (int i = 0; i < heldItems.Length; i++)
            {
                Console.Write($"{heldItems[i]} ");
            }
            Console.WriteLine();
        }

        public void TakeDamage(int damageDealth)
        {
            if (currentHealth > 0)
            {
                currentHealth -= damageDealth;
            }
        }
    }
}
