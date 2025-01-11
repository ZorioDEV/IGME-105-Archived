// Tyler Bye 
// 11/10/2024
// Monopoly Simulation
namespace ByeT_HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            Dice myDice = new Dice();
            Monopoly myMonopoly = new Monopoly(100000, 25);
            double oneDiceTotal = 0;
            double twoDiceTotal = 0;
            int diceNumber;
            double[] visitPercentages;

            // prints out 100 rolls for one dice
            for (int i = 0; i < 100; i++)
            {
                diceNumber = myDice.RollDice();
                Console.Write($"{diceNumber} ");
                oneDiceTotal += diceNumber;
            }
            // tells user the average of the 100 rolls
            Console.WriteLine($"\nAverage roll for a single die: {oneDiceTotal / 100}\n\n");

            // prints out 100 rolls for two dice
            for (int i = 0; i < 100; i++)
            {
                diceNumber = myDice.RollDice(2);
                Console.Write($"{diceNumber} ");
                twoDiceTotal += diceNumber;
            }
            // tells user the average of the 100 rolls
            Console.WriteLine($"\nAverage roll for 2 dice: {twoDiceTotal / 100}");

            // rus a game of monpoly & gives the average visits of every tile
            visitPercentages = myMonopoly.Analyze();
            myMonopoly.PrintResults(visitPercentages);

        }
    }
}
