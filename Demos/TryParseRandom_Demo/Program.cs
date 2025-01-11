namespace TryParseRandom_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            int result = -1;
            bool success = false;
            Random rng = new Random();

            // prints random number methods
            Console.WriteLine(rng.Next());
            Console.WriteLine(rng.Next(10));
            Console.WriteLine(rng.Next(10, 21));
            Console.WriteLine(rng.NextDouble());
            
            // asks user for a number between 1-10
            Console.Write("Give a number between 1-10: ");
            // int userInput = int.Parse(Console.ReadLine()!.Trim());
            success = int.TryParse(Console.ReadLine()!.Trim(), out result);


            // test if input is invalid 
            while (!success || (result < 1 || result > 10))
            {
                Console.Write("Invlaid! Try again: ");
                success = int.TryParse(Console.ReadLine()!.Trim(), out result);
            }

            // test if user entered 5 or not
            if (result == 5)
            {
                Console.WriteLine("Yay! You got it right!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
