using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomAshKA
{
    internal class Program
    {

        static void Main(string[] args)
        {
               double a, b;
            double i;
            double c;
            string d, f;
            Console.WriteLine("Enter A and B numbers"); // Ввод числа
            d = Console.ReadLine();
            a = Convert.ToDouble(d);
            d = Console.ReadLine();
            b = Convert.ToDouble(d);
            Console.WriteLine("Enter an action key"); // Пользователю предоставлен выбор из 4 команд:
            Console.WriteLine("1 = Plus, 2 = Minus, 3 = Times, 4 = Divide"); // Сложение, вычитание, умножение и деление.
            f = Console.ReadLine();
            i = Convert.ToDouble(f);
            if (i == 1)
            {
                c = a + b;
                Console.WriteLine("{0}+{1}={2}", a, b, c);
                Console.ReadKey();
            }
            else if (i == 2)
            {
                c = a - b;
                Console.WriteLine("{0}-{1}={2}", a, b, c);
                Console.ReadKey();
            }
            else if (i == 3)
            {
                c = a * b;
                Console.WriteLine("{0}*{1}={2}", a, b, c);
                Console.ReadKey();
            }
            else if (i == 4)
            {
                c = a / b;
                Console.WriteLine("{0}/{1}={2}", a, b, c);
                Console.ReadKey();
            }
            else // Если пользователь не выберет числом предложенное математическое действие, консоль сообщит об этом и приложение закроется.
            {
                Console.WriteLine("Wrong Number");
                Console.ReadKey();
            }
        }
    }
}
