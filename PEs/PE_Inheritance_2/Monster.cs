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
        public virtual void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Constitution: {constitution}");
            Console.WriteLine($"Undead? {isUndead}");
            Console.WriteLine($"Animated? {isAnimated}");
        }

        /// <summary>
        /// Prints that the Monster ate a victim.
        /// </summary>
        /// <param name="victim">Name of victim.</param>
        public virtual void Eat(string victim)
        {
            Console.WriteLine($"{name} devours {victim}.");
        }

        /// <summary>
        /// Tells user if the Monster is old or young and animated or undead.
        /// </summary>
        /// <returns>Various responses based on given data.</returns>
        public override string ToString()
        {
            // test if is animated
            if (isAnimated)
            {
                // checks age & tells user if Monster is old or young
                if (age >= 60)
                {
                    return $"{name} is old at the ripe age of {age}. " +
                        $"They are existing with {constitution} constitution.";
                }
                else
                {
                    return $"{name} is young at {age} years old. " +
                        $"They are existing with {constitution} constitution.";
                }
            }
            // not animated
            else
            {
                // tests if is undead
                if (isUndead)
                {
                    return $"{name}'s constitution has fallen to zero. " +
                        $"They are no longer animated and cannot be revived.";
                }
                // isnt undead
                else
                {
                    return $"{name}'s constitution has fallen to zero. " +
                        $"They are no longer animated but can be resuscitated.";
                }
            }
        }
    }
}
