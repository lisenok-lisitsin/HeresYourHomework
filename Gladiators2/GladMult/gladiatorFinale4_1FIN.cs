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
            int health1, health2, health11, health22, counter, heal1, heal2;
            double armor1, armor2, damage, total1, total2, armour1, armour2, armour11, armour22;
            string h1, h2, a1, a2, pass, tpass, h11, h22, a11, a22;
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
                Console.WriteLine("\nEnter the first character's min health: ");
                h1 = Console.ReadLine();
                health1 = Convert.ToInt32(h1);
                Console.WriteLine("\nEnter the first character's max health: ");
                h11 = Console.ReadLine();
                health11 = Convert.ToInt32(h11);
                if (health1 > health11)
                {
                    Console.WriteLine("\nIncorrect input");
                    return;
                }
                Console.WriteLine("\nEnter the first character's min armor: ");
                a1 = Console.ReadLine();
                armour1 = Convert.ToDouble(a1);
                Console.WriteLine("\nEnter the first character's max armor: ");
                a11 = Console.ReadLine();
                armour11 = Convert.ToDouble(a11);
                if (armour1 > armour11)
                {
                    Console.WriteLine("\nIncorrect input");
                    return;
                }
                Console.WriteLine("\nEnter the second character's min health: ");
                h2 = Console.ReadLine();
                health2 = Convert.ToInt32(h2);
                Console.WriteLine("\nEnter the second character's max health: ");
                h22 = Console.ReadLine();
                health22 = Convert.ToInt32(h22);
                if (health2 > health22)
                {
                    Console.WriteLine("\nIncorrect input");
                    return;
                }
                Console.WriteLine("\nEnter the second character's min armor: ");
                a2 = Console.ReadLine();
                armour2 = Convert.ToDouble(a2);
                Console.WriteLine("\nEnter the second character's max armor: ");
                a22 = Console.ReadLine();
                armour22 = Convert.ToDouble(a22);
                if (armour2 > armour22)
                {
                    Console.WriteLine("\nIncorrect input");
                    return;
                }

                heal1 = rand.Next(health1, health11 + 1);
                heal2 = rand.Next(health2, health22 + 1);
                armor1 = rand.Next(Convert.ToInt32(armour1), Convert.ToInt32(armour11) + 1);
                armor2 = rand.Next(Convert.ToInt32(armour2), Convert.ToInt32(armour22) + 1);

                Console.WriteLine($"\nFirst gladiator's stats:\nHealth: {heal1}\nArmor: {armor1}");
                Console.WriteLine($"\nSecond gladiator's stats:\nHealth: {heal2}\nArmor: {armor2}");
                Console.ReadKey();

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
                if (heal1 > heal2)
                {
                    damage = rand.Next(1, heal1 + 1);
                    total1 = heal1 - (damage - (damage * (armor1 / 100)));
                    total2 = heal2 - (damage - (damage * (armor2 / 100)));
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
                else if (heal1 < heal2)
                {
                    damage = rand.Next(1, heal2 + 1);
                    total1 = heal1 - (damage - (damage * (armor1 / 100)));
                    total2 = heal2 - (damage - (damage * (armor2 / 100)));
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
                    damage = rand.Next(1, heal1 + 1);
                    total1 = heal1 - (damage - (damage * (armor1 / 100)));
                    total2 = heal2 - (damage - (damage * (armor2 / 100)));
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
