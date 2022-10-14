using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            int health;
            double armor, damage, total;
            string h, a;
            Random rand = new Random();
            Console.WriteLine("Enter your character's health: ");
            h = Console.ReadLine();
            health = Convert.ToInt32(h);
            Console.WriteLine("Enter your character's armor: ");
            a = Console.ReadLine();
            armor = Convert.ToDouble(a);
            Console.WriteLine($"\nYour health is {health}"+$"\nYour armor is {armor}%");
            damage = rand.Next(1, health + 1);
            Console.WriteLine($"\nDamage applied is {damage}");
            total = health - (damage-(damage * (armor / 100)));
            Console.WriteLine($"\nYour current health is {total}");
            Console.ReadKey();
        }
    }
}
