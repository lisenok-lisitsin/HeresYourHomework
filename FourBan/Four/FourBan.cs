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
            int amo;
            double dis, pr, total;
            string s, d, z;
            Console.WriteLine("Enter Price"); // Ввод цены за единицу товара.
            s = Console.ReadLine();
            pr = Convert.ToDouble(s);
            Console.WriteLine("Enter Discount (%)"); // Значение скидки
            d = Console.ReadLine();
            dis = Convert.ToDouble(d);
            Console.WriteLine("Enter Amount"); // Значение количества товара
            z = Console.ReadLine();
            amo = Convert.ToInt32(z);
            total = (pr-(pr * (dis / 100))) * amo; // Рассчёт итоговой стоимости
            Console.WriteLine("Total Price = {0}", total);
            Console.ReadKey();
        }
    }
}
