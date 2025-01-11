// Tyler Bye 
// 10/30/2024
// Learning Classes & Objects
namespace ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random myRNG = new Random();
            int randomNumber = myRNG.Next(1, 101);

            // Default 
            Weapon myStabby = new Weapon();
            Console.WriteLine(myStabby.materials[0]);

            // Parameterized
            Weapon myCutty = new Weapon(75, "Buster Sword", 9001, 9002, new string[] {"mithrill"});
            Console.WriteLine(myCutty);
        }
    }
}
