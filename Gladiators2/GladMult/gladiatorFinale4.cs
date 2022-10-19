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
            int health1, health2, counter;
            double armor1, armor2, damage, total1, total2;
            string h1, h2, a1, a2, pass, tpass;
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
                Console.WriteLine("\nEnter the first character's health: ");
                h1 = Console.ReadLine();
                health1 = Convert.ToInt32(h1);
                Console.WriteLine("\nEnter the first character's armor: ");
                a1 = Console.ReadLine();
                armor1 = Convert.ToDouble(a1);
                Console.WriteLine("\nEnter the second character's health: ");
                h2 = Console.ReadLine();
                health2 = Convert.ToInt32(h2);
                Console.WriteLine("\nEnter the second character's armor: ");
                a2 = Console.ReadLine();
                armor2 = Convert.ToDouble(a2);
                if (armor1 == 100 && armor2 == 100)
                {
                    Console.WriteLine("\nNobody can't be hit because of they both having 100% armor");
                    Console.ReadKey();
                }
                else if (armor1 >= 100)
                {
                    Console.WriteLine("\nThe first gladiator's armor is 100%, you cannot hit him! He's winner");
                    Console.ReadKey();
                }   
                else if (armor2 >= 100)
                {
                    Console.WriteLine("\nThe second gladiator's armor is 100%, you cannot hit him! He's winner");
                    Console.ReadKey();
                }
                if (armor1 >= 100 | armor2 >= 100 | armor1 == 100 | armor2 == 100)
                {
                    return;
                }
                if (health1 > health2)
                {
                    damage = rand.Next(1, health1 + 1);
                    total1 = health1 - (damage - (damage * (armor1 / 100)));
                    total2 = health2 - (damage - (damage * (armor2 / 100)));
                    Console.WriteLine($"\nDamage applied is: {damage}");
                    if (total1 > total2)
                    {
                        Console.WriteLine($"\nThe first gladiator wins with {total1} HP, while the second gladiator's health is {total2}");
                        Console.ReadKey();
                    }
                    else if (total1 < total2)
                    {
                        Console.WriteLine($"\nThe second gladiator wins with {total2} HP, while the first gladiator's health is {total1}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"\nNobody wins; The first gladiator's health is {total1} and the second gladiator's one is {total2} too");
                    }    
                }
                else if (health1 < health2)
                {
                    damage = rand.Next(1, health2 + 1);
                    total1 = health1 - (damage - (damage * (armor1 / 100)));
                    total2 = health2 - (damage - (damage * (armor2 / 100)));
                    Console.WriteLine($"\nDamage applied is: {damage}");
                    if (total1 > total2)
                    {
                        Console.WriteLine($"\nThe first gladiator wins with {total1} HP, while the second gladiator's health is {total2}");
                        Console.ReadKey();
                    }
                    else if (total1 < total2)
                    {
                        Console.WriteLine($"\nThe second gladiator wins with {total2} HP, while the first gladiator's health is {total1}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"\nNobody wins; The first gladiator's health is {total1} and the second gladiator's one is {total2} too");
                    }
                }
                else
                {
                    damage = rand.Next(1, health1 + 1);
                    total1 = health1 - (damage - (damage * (armor1 / 100)));
                    total2 = health2 - (damage - (damage * (armor2 / 100)));
                    Console.WriteLine($"\nDamage applied is: {damage}");
                    if (total1 > total2)
                    {
                        Console.WriteLine($"\nThe first gladiator wins with {total1} HP, while the second gladiator's health is {total2}");
                        Console.ReadKey();
                    }
                    else if (total1 < total2)
                    {
                        Console.WriteLine($"\nThe second gladiator wins with {total2} HP, while the first gladiator's health is {total1}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"\nNobody wins; The first gladiator's health is {total1} and the second gladiator's one is {total2} too");
                    }
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
