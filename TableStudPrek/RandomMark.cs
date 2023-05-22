using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TableStudPrek
{
    public class RandomMark
    {
        
        private static string[] MarksDEF = { "Н/А", "2", "3", "4", "5" };
        private static string[] MarksSPE = { "не зачёт", "зачёт", "Н/А" };

        public static string[] totalD;
        public static string[] totalSP;

        public static string totalDS;

        public static string[] Default(int num1)
        {
            Random r = new Random();
            totalD = new string[num1];
            int temp;

            for (int  i = 0; i < num1; i++)
            {
                temp = r.Next(0, 101);
                if (temp <= 25)
                {
                    totalD[i] = MarksDEF[0];
                }
                else if (temp > 25 && temp <= 50)
                {
                    totalD[i] = MarksDEF[1];
                }
                else if (temp > 50 &&  temp <= 65)
                {
                    totalD[i] = MarksDEF[2];
                }
                else if (temp > 65 && temp <= 75)
                {
                    totalD[i] = MarksDEF[3];
                }
                else if (temp > 75)
                {
                    totalD[i] = MarksDEF[4];
                }
            }
            return totalD;
        }

        public static string DefaultStandalone()
        {
            Random r = new Random();
            int temp;

            temp = r.Next(0, 101);
            if (temp <= 25)
            {
                totalDS = MarksDEF[0];
            }
            else if (temp > 25 && temp <= 50)
            {
                totalDS = MarksDEF[1];
            }
            else if (temp > 50 && temp <= 65)
            {
                totalDS = MarksDEF[2];
            }
            else if (temp > 65 && temp <= 75)
            {
                totalDS = MarksDEF[3];
            }
            else if (temp > 75)
            {
                totalDS = MarksDEF[4];
            }

            return totalDS;
        }

        public static string[] Special(int num1)
        {
            Random r = new Random();
            totalSP = new string[num1];
            int temp;

            for (int i = 0; i < num1; i++)
            {
                temp = r.Next(0, 101);
                if (temp <= 25)
                {
                    totalSP[i] = MarksSPE[2];
                }
                else if (temp > 25 && temp < 50)
                {
                    totalSP[i] = MarksSPE[0];
                }
                else if (temp >= 50)
                {
                    totalSP[i] = MarksSPE[1];
                }
            }
            return totalSP;
        }

    }
}
