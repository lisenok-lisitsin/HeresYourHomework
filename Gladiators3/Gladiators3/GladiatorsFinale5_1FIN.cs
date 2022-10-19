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
            int counter, counter2;
            double health1, health2, armor1, armor2, damage, total1, total2, fhel1, fhel2;
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
                health1 = Convert.ToDouble(h1);
                Console.WriteLine("\nEnter the first character's armor: ");
                a1 = Console.ReadLine();
                armor1 = Convert.ToDouble(a1);
                Console.WriteLine("\nEnter the second character's health: ");
                h2 = Console.ReadLine();
                health2 = Convert.ToDouble(h2);
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
                total1 = 0;
                total2 = 0;
                fhel1 = health1;
                fhel2 = health2;
                counter2 = 0;
                do
                {
                    if (health1 > health2)
                    {
                        damage = rand.Next(1, Convert.ToInt32(fhel2) + 1 );
                        total1 = health1 - (damage - (damage * (armor1 / 100)));
                        total2 = health2 - (damage - (damage * (armor2 / 100)));
                        Console.WriteLine($"\nDamage applied is: {damage}");
                        health1 = total1;
                        health2 = total2;
                        counter2++;
                    }
                    else if (health2 > health1)
                    {
                        damage = rand.Next(1, Convert.ToInt32(fhel1) + 1);
                        total1 = health1 - (damage - (damage * (armor1 / 100)));
                        total2 = health2 - (damage - (damage * (armor2 / 100)));
                        Console.WriteLine($"\nDamage applied is: {damage}");
                        health1 = total1;
                        health2 = total2;
                        counter2++;
                    }
                    else
                    {
                        damage = rand.Next(1, Convert.ToInt32(fhel2) + 1);
                        total1 = health1 - (damage - (damage * (armor1 / 100)));
                        total2 = health2 - (damage - (damage * (armor2 / 100)));
                        Console.WriteLine($"\nDamage applied is: {damage}");
                        health1 = total1;
                        health2 = total2;
                        counter2++;
                    }
                }
                while (total1 > 0 && total2 > 0);
                if (total1 <= 0)
                {
                    Console.WriteLine($"\nThe first gladiator has fallen with {total1} HP in {counter2} hits, while the second one is alive with {total2} HP");
                    Console.ReadKey();
                }
                else if (total2 <= 0)
                {
                    Console.WriteLine($"\nThe second gladiator has fallen with {total2} HP in {counter2} hits, while the first one is alive with {total1} HP");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"\nBoth gladiators are dead in {counter2} hits..");
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