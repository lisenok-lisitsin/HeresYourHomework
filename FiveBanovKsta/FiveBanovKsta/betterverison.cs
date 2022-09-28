using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveBanovKsta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, l;
            int min, max;
            string s;
            Random r = new Random();
            Console.WriteLine("Enter MIN and MAX values"); // Ввод чисел для заданного рандомизатором диапазона.
            s = Console.ReadLine();
            min = Convert.ToInt32(s);
            s = Console.ReadLine();
            max = Convert.ToInt32(s);
            x1 = r.Next(min, max+1);
            x2 = r.Next(min, max+1);
            y1 = r.Next(min, max+1);
            y2 = r.Next(min, max+1);
            l = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); // Формула вычисления
            Console.WriteLine("X1 = {0}, X2 = {1}, Y1 = {2}, Y2 = {3}", x1, x2, y1, y2); // Вывод значений, заданных рандомизатором.
            Console.WriteLine("L = {0}", l); // Вывод итогового числа.
            Console.ReadKey();
        }
    }
}
