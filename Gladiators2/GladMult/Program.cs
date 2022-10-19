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
            int counter;
            string pass, tpass;
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
                
            }
            else
            {
                Console.WriteLine("\nOut of tries");
                Console.ReadKey();
            }
        }
    }
}
