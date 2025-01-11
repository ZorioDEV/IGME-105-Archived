using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Inheritance_1
{
    internal class Monster
    {
        // *** FIELDS ***
        private string name;
        private int age;
        private double constitution;
        private bool isUndead;
        private bool isAnimated;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-Only property for Monster's name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Read & Write property for Monster's constitution.
        /// </summary>
        public double Constitution
        {
            get
            {
                return constitution;
            }
            set
            {
                constitution = value;
            }
        }

        /// <summary>
        /// Read & Write property for Monster's isAnimated.
        /// </summary>
        public bool IsAnimated
        {
            get
            {
                return isAnimated;
            }
            set
            {
                isAnimated = value;
            }
        }

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Default Monster values if nothing is specified.
        /// </summary>
        public Monster()
        {
            name = "unknown";
            age = 0;
            constitution = 0;
            isUndead = false;
            isAnimated = false;
    }

        /// <summary>
        /// Parameterized Monster values.
        /// </summary>
        /// <param name="name">Name of the monster.</param>
        /// <param name="age">Age of the monster.</param>
        /// <param name="constitution">The monster's constitution.</param>
        /// <param name="isUndead">If the monster is undead.</param>
        public Monster(string name, int age, double constitution, bool isUndead)
        {
            this.name = name;
            this.age = age;
            this.constitution = constitution;
            this.isUndead = isUndead;

            // when constitution is greater than 0 the monster is animated
            if (constitution > 0)
            {
                isAnimated = true;
            }
            else
            {
                isAnimated = false;
            }
        }

        // *** METHODS ***
        /// <summary>
        /// Prints out all of the Monster's data.
        /// </summary>
        public void PrintMonster()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Constitution: {constitution}");
            Console.WriteLine($"Undead? {isUndead}");
            Console.WriteLine($"Animated? {isAnimated}");
        }
    }
}
