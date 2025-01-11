namespace DebuggingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // runtime error w/ dividing by zero
            /* int number = 0;
            int result = 10 / number; */

            //
            int x = 10;
            x = x * 7;
            x = x / 3;
            Console.WriteLine(x);

            // new Trim method & clarifying inputs for user
            /* Console.Write("Enter your name: ");
            string name = Console.ReadLine()!.Trim();
            int howManyfit = 100 / name.Length;
            Console.WriteLine($"{name} has {name.Length} letters and " +
                $"can fit {howManyfit} times in 100 characters."); */
        }
    }
}
