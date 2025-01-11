namespace PE_HelloGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** ALL VARIABLES USED ***
            string userInput;
            double billTotal;
            
            // basic "hello world" start & 3 of my top favorite games
            Console.WriteLine("Hello, World!");
            Console.WriteLine("I love the game Valorant.");
            Console.WriteLine("I love the game Little Big Planet.");
            Console.WriteLine("I love the game Pokemon Emerald.");

            // asks user for their total bill cost
            Console.WriteLine();
            Console.Write("Enter your bill total: $");
            userInput = Console.ReadLine()!;
            billTotal = double.Parse(userInput);

            // calculates what 15% and 20% tips would cost the user
            Console.WriteLine($"15% tip: ${Math.Round((billTotal * 0.15), 2)}");
            Console.WriteLine($"20% tip: ${Math.Round((billTotal * 0.20), 2)}");

        }
    }
}
