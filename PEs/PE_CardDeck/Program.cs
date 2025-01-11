namespace PE_CardDeck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            Deck myDeck = new Deck();
            int result = -1;
            bool success = false;

            // prints out every card in a single deck
            myDeck.PrintDeck();

            // asks user for how many cards they watnt to randomly deal
            Console.Write("\nHow many cards should I deal? (1–52): ");
            success = int.TryParse(Console.ReadLine()!.Trim(), out result);

            // tests if the input is parsable
            while (!(success && result >= 1 && result <= 52))
            {
                Console.Write("Invalid. Enter 1-52: ");
                success = int.TryParse(Console.ReadLine()!.Trim(), out result);
            }

            // prints out random amount of dealed cards
            myDeck.Deal(result);
        }
    }
}
