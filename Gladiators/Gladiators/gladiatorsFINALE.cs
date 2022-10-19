using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladMult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health, counter;
            double armor, damage, total;
            string h, a, pass, tpass;
            tpass = "Sacred";
            counter = 0;
            Console.WriteLine("Welcome to the Gladiators.io\nPlease, enter the password\n");
            do
            {
                pass = Console.ReadLine();
                if (pass != tpass)
                {
                    counter++;
                    Console.WriteLine("\nIncorrect password");
                    Console.WriteLine($"\nYour number of incorrect tries = {counter}");
                    Console.WriteLine("\nPlease, try again\n");
                }
                else
                {
                    Console.WriteLine("\nCorrect password!\n");
                }
            }
            while (pass != tpass && counter < 3);

            if (pass == tpass)
            {
                Random rand = new Random();
                Console.WriteLine("Enter your character's health: ");
                h = Console.ReadLine();
                health = Convert.ToInt32(h);
                Console.WriteLine("Enter your character's armor: ");
                a = Console.ReadLine();
                armor = Convert.ToDouble(a);
                Console.WriteLine($"\nYour health is {health}" + $"\nYour armor is {armor}%");
                if (armor >= 100)
                {
                    Console.WriteLine($"\nYour health remain the same amount: {health}");
                }
                else
                {
                    damage = rand.Next(1, health + 1);
                    Console.WriteLine($"\nDamage applied is {damage}");
                    total = health - (damage - (damage * (armor / 100)));
                    Console.WriteLine($"\nYour current health is {total}");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("\nOut of tries");
                Console.ReadKey();
            }
        }
    }
}
