// Tyler Bye
// 09/27/2024
// Learning Switch and String Formatting
namespace PE_SwitchStringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** PSEUDOCODE ***
            /*
            WELCOME user & ASK if they wish to continue

            IF user responds 'yes' or 'y'
                Print "Lets go Shopping!"
                Print the item list
                ASK user to select an item
                Use a SWITCH
                    CASE 1
                        Print "You selected: Healing Potion"
                        Store value for healing potion
                    CASE 2
                        Print "You selected: Sword"
                        Store value for sword
                    CASE 3
                        Print "You selected: Shield"
                        Store value for healing shield
                    CASE 4
                        Print "You selected: Armor"
                        Store value for armor
                    CASE 5
                        Print "You exit"
                    DEFUALT
                        Print "Unknown item"
                        Make them buy the healing potion
                ASK user how many they would like to buy
                IF user input is positive
                    Print total cost and thank user
                OTHERWISE
                    Print "Invalid" and set amount to 1
                    Print total cost and thank user
            OTHERWISE user responds 'no' or 'n' 
                Print that the user exits and thank them
            OTHERWISE
                Print "Invalid" 
                Print thanking them for stopping by
            */

            // *** VARIABLES ***
            string userInput;
            int healingPotionCost = 10;
            int swordCost = 50;
            int shieldCost = 40;
            int armorCost = 100;
            int userItem = 0;
            string itemName = "";
            int itemCost = 0;
            int itemAmount = 0;
            double totalCost = 0;

            // *** MAIN CODE ***
            // welcomes user & asks if they would like to continue to the shop
            Console.WriteLine("Welcome to the Monster Hunter Shop!");
            Console.Write("Do you wish to continue? ");
            userInput = Console.ReadLine()!.ToLower().Trim();

            // tests users input if they said yes/y or no/n or invalid response
            // runs if user inputed yes or y
            if (userInput == "yes" || userInput == "y")
            {
                Console.WriteLine("Excellent! Let’s go shopping!");
                Console.WriteLine();
                // lists the shops items & their prices
                Console.WriteLine("Please select an item:\n" +
                    "1. Healing Potion - {0}\n" +
                    "2. Sword - {1}\n" +
                    "3. Shield - {2}\n" +
                    "4. Armor - {3}\n" +
                    "5. Exit", 
                    healingPotionCost.ToString("C0"), swordCost.ToString("C0"), 
                    shieldCost.ToString("C0"), armorCost.ToString("C0"));
                // asks user which item they would like to buy & parses
                Console.WriteLine();
                Console.Write("Enter the number of the item you wish to purchase: ");
                userInput = Console.ReadLine()!.ToLower().Trim();
                userItem = int.Parse(userInput);
                // tests what item the user selected & stores the correct values
                switch (userItem)
                {
                    case 1:
                        Console.WriteLine("You selected: Healing Potion");
                        itemName = "Healing Potion";
                        itemCost = healingPotionCost;
                        break;
                    case 2:
                        Console.WriteLine("You selected: Sword");
                        itemName = "Sword";
                        itemCost = swordCost;
                        break;
                    case 3:
                        Console.WriteLine("You selected: Shield");
                        itemName = "Shield";
                        itemCost = shieldCost;
                        break;
                    case 4:
                        Console.WriteLine("You selected: Armor");
                        itemName = "Armor";
                        itemCost = armorCost;
                        break;
                    // ends program if user exits
                    case 5:
                        Console.WriteLine("You leave the shop. Thanks for coming by!");
                        return;
                    // sets the item to healing potion if response is invalid
                    default:
                        Console.WriteLine("Unknown item. You will purchase a healing potion.");
                        itemName = "Healing Potion";
                        itemCost = healingPotionCost;
                        break;
                }
                // asks user how many of the item they want & parses
                Console.WriteLine();
                Console.Write("How many would you like to buy? ");
                userInput = Console.ReadLine()!.ToLower().Trim();
                itemAmount = int.Parse(userInput);
                // tests if the user input for item amount is negative
                if (itemAmount >= 0)
                {
                    // calculates total cost with user's amount 
                    totalCost = (itemAmount * itemCost);
                    Console.WriteLine("Total price: {0} {1} x {2} is {3}",
                        itemAmount, itemName, itemCost.ToString("C0"), 
                        totalCost.ToString("C2"));
                }
                else
                {
                    // calculates total cost with 1 amount if user inputs invalid response 
                    Console.WriteLine("Not a valid number of units. Purchasing a quantity of 1.");
                    itemAmount = 1;
                    totalCost = (itemAmount * itemCost);
                    Console.WriteLine("Total price: {0} {1} x {2} is {3}", 
                        itemAmount, itemName, itemCost.ToString("C0"),
                        totalCost.ToString("C2"));
                }
                // thanks the user for shopping
                Console.WriteLine("Thank you for shopping at the Monster Hunter Shop!");
            }
            // runs if user inputed no or n
            else if (userInput == "no" || userInput == "n")
            {
                Console.WriteLine("Exiting the shop. Thanks for stopping by!");
            }
            // runs if user inputed an invalid response
            else
            {
                Console.WriteLine("I don’t understand that phrase... Thanks for stopping by!");
            }
        }
    }
}
