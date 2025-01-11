
// Tyler Bye
// 09/21/2024
// Relational Operators and If Statements


namespace IfStatementPE_STARTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Variable Block with initial values
            // ----------------------------------------------------------------
            // For gathering initial player input:
            string userInput = "";
            int userWeaponChoice = 0;
            string playerWeapon = "";

            // Other gameplay variables:
            const int FullPlayerHealth = 100;
            int currentPlayerHealth = 12;
            bool healthPackPickedUp = true;
            int experiencePoints = 125;
            int playerLevel = 2;
            string gameStatus = "playing";
            bool fightBoss = false;

            // ----------------------------------------------------------------
            // Initial Gameplay
            // ----------------------------------------------------------------

            // Welcome the player and get their weapon of choice.
            Console.WriteLine("Welcome player!");
            Console.WriteLine();
            Console.WriteLine("To get started, choose your weapon: ");
            Console.Write("Type 1 for a SWORD or 2 for a DAGGER: ");
            userWeaponChoice = int.Parse(Console.ReadLine()!.Trim());
            Console.WriteLine();


            // Depending on their input, assign one of 3 weapons:
            // 1 --> sword
            // 2 --> dagger
            // ? --> sharpened stick
            if (userWeaponChoice == 1)
            {
                playerWeapon = "sword";
                Console.WriteLine($"I see you chose the {playerWeapon.ToUpper()}!");
            }
            else if (userWeaponChoice == 2)
            {
                playerWeapon = "dagger";
                Console.WriteLine($"I see you chose the {playerWeapon.ToUpper()}!");
            }
            else
            {
                playerWeapon = "sharpened stick";
                Console.WriteLine(
                    $"I do not recognize that number. The game will continue with you" +
                    $" holding a {playerWeapon.ToUpper()}.");
            }


            // ----------------------------------------------------------------
            // If Statements
            // *** COMPLETE THESE IF STATEMENTS BASED ON THE INSTRUCTIONS BELOW ***
            // ----------------------------------------------------------------

            // If the player's weapon is a sword, increase their XP by 25 points. 
            if (userWeaponChoice == 1)
            {
                experiencePoints = (experiencePoints + 25);
                Console.WriteLine($"+25 XP! Total experience is now {experiencePoints}!");
            }
            // If the player's weapon is a dagger, increase their XP by 10 points. 
            else if (userWeaponChoice == 2)
            {
                experiencePoints = (experiencePoints + 10);
                Console.WriteLine($"+10 XP! Total experience is now {experiencePoints}!");
            }

            // If the player gains at least 150 XP points, increase their level
            // by 1 and print a congratulations message.
            // i.e. "Congratulations! You leveled up!"
            if (experiencePoints >= 150)
            {
                Console.WriteLine("Congratulations! You leveled up!");
            }


            // If the player's current health is below 15, print a statement saying
            // "Warning: Your health of __ is low!"
            // i.e.  "Warning: Your health of 7 is low!"
            if (currentPlayerHealth < 15)
            {
                Console.WriteLine($"Warning: Your health of {currentPlayerHealth} is low!");
            }
            Console.WriteLine();


            // ----------------------------------------------------------------
            // If-Else Statements
            // *** COMPLETE THESE IF-ELSE STATEMENTS BASED ON THE INSTRUCTIONS BELOW ***
            // ----------------------------------------------------------------

            // Ask the user whether they want to fight a boss they just encountered.  
            // Set the fightBoss variable to true or false based on their answer.
            // Create a 'catch all' case for if they do not enter valid input.
            Console.WriteLine("You have encountered a boss!");
            Console.Write("Would you like to fight the boss? (yes/no): ");
            userInput = Console.ReadLine()!.ToLower().Trim();
            if (userInput == "yes")
            {
                fightBoss = true;
                Console.WriteLine($"You pull out your {playerWeapon} " +
                    $"and prepare for battle!");
            }
            else if (userInput == "no")
            {
                fightBoss = false;
                Console.WriteLine("You safely run away!");
            }
            else
            {
                fightBoss = true;
                Console.WriteLine("[Invalid Input]: You become mad and run at the boss!");
            }
            // If they want to fight the boss, reduce their health by 50 hit points.
            // Print a message that their health dropped to __ points.
            // i.e. "Your health is now ___ hit points."
            // Otherwise, print a message that they run away to save their life.
            // i.e. "Smart choice. That boss looked gnarly!"
            if (fightBoss == true)
            {
                currentPlayerHealth = (currentPlayerHealth - 50);
                Console.WriteLine($"Your health is now {currentPlayerHealth} hit points.");
            }
            else
            {
                Console.WriteLine("Smart choice. That boss looked gnarly!");
            }
            Console.WriteLine();


            // Ask the user whether they want to pick up a health pack they just discovered.  
            // Set the healthPackPickedUp variable to true or false based on their answer.
            // Create a 'catch all' case for if they do not enter valid input.
            Console.WriteLine("You found a health pack!");
            Console.Write("Would you like to pick it up? (yes/no): ");
            userInput = Console.ReadLine()!.ToLower().Trim();
            if (userInput == "yes")
            {
                healthPackPickedUp = true;
            }
            else if (userInput == "no")
            {
                healthPackPickedUp = false;
            }
            else
            {
                healthPackPickedUp = false;
            }


            // If player chooses to pick up a health pack, set current health
            // back to its full capacity and print a message that the player is fully healed.
            // i.e. "You are fully healed with __ hit points!"
            // Otherwise they don't pick the pack up, print a message that they missed the health pack.
            // i.e. "Just missed a health pack. Hopefully there will be more later!"
            if (healthPackPickedUp == true)
            {
                currentPlayerHealth = FullPlayerHealth;
                Console.WriteLine($"You are fully healed with {FullPlayerHealth} hit points!");
            }
            else
            {
                Console.WriteLine("Just missed a health pack. " +
                    "Hopefully there will be more later!");
            }
            Console.WriteLine();


            // If the player's health drops to 0 or below, change the game status to
            // "game over" and print a message.
            // i.e. "Imminent death. Game over!"
            // Otherwise, print a message that their health is ok to continue playing. 
            // i.e. "Luckily you are good to keep playing with health of __ hit points."
            if (currentPlayerHealth <= 0)
            {
                Console.WriteLine("You have died!");
                Console.WriteLine("GAME OVER!");
            }
            else
            {
                Console.WriteLine($"Luckily you are good to keep playing with " +
                    $"health of {currentPlayerHealth} hit points.");
            }
        }
    }
}
