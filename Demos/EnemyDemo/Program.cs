using System.Drawing;

namespace EnemyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy myEnemy = new Enemy("Bob", 75);
            myEnemy.PrintEnemy();
            myEnemy.TakeDamage(5);
            myEnemy.PrintEnemy();
        }
    }
}
