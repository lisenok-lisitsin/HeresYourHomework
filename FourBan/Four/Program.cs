using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            double dis, pr, total;
            string s, d, z;
            Console.WriteLine("Enter Price");
            s = Console.ReadLine();
            pr = Convert.ToDouble(s);
            Console.WriteLine("Enter Discount (%)");
            d = Console.ReadLine();
            dis = Convert.ToDouble(d);
            Console.WriteLine("Enter Amount");
            z = Console.ReadLine();
            x = Convert.ToInt32(z);
            total = (pr-(pr * (dis / 100))) * x;
            Console.WriteLine("Total Price = {0}", total);
            Console.ReadKey();
        }
    }
}
