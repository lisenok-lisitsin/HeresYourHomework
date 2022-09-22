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
            Console.WriteLine("Enter MIN and MAX values");
            s = Console.ReadLine();
            min = Convert.ToInt32(s);
            s = Console.ReadLine();
            max = Convert.ToInt32(s);
            x1 = r.Next(min, max);
            x2 = r.Next(min, max);
            y1 = r.Next(min, max);
            y2 = r.Next(min, max);
            l = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine("X1 = {0}, X2 = {1}, Y1 = {2}, Y2 = {3}", x1, x2, y1, y2);
            Console.WriteLine("L = {0}", l);
            Console.ReadKey();
        }
    }
}
