using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableStudPrek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bacon_Click(object sender, EventArgs e)
        {
            int rowco = Convert.ToInt32(rowc.Text);
            int colco = Convert.ToInt32(colc.Text);
            
        }

        public class RandomName
        {
            private static Random random = new Random();

            private static string[] firstNames = { "Иван", "Родион", "Святослав", "Фёдор", "Михаил", "Максим", "Сергей", "Артём", "Андрей", "Владимир", "Ярослав", "Валентин", "Геннадий", "Игорь", "Олег" };
            private static string[] lastNames = { "Рахматов", "Пражин", "Прядко", "Филипов", "Васильев", "Эсмиральдов", "Кац", "Демошенко", "Пономарёв", "Кравченко", "Ягудин", "Маршаков", "Славянских" };
            private static string[] midNames = { "И.", "В.", "Б.", "Г.", "А.", "С.", "Р." };

            private static string[] firstNamesF = { "Жанна", "Констанция", "Екатерина", "Анастасия", "Марьяна", "Мария", "Александра", "Евгения" };
            private static string[] lastNamesF = { "Ибрагимова", "Сергеева", "Тролл", "Шпицманн", "Велинская", "Рыбникова" };
            private static string[] midNamesF = { "С.", "Д.", "Е.", "Г.", "М.", "И.", "К." };

            public static string GenFName()
            {
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                string midName = midNames[random.Next(midNames.Length)];
                return $"{lastName} {firstName} {midName}";
            }

            public static string GetFNameF()
            {
                string firstNameF = firstNamesF[random.Next(firstNamesF.Length)];
                string lastNameF = lastNamesF[random.Next(lastNamesF.Length)];
                string midNameF = midNamesF[random.Next(midNamesF.Length)];
                return $"{lastNameF} {firstNameF} {midNameF}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int c;
            for (int i = 0; i < 29; i++)
            {
                c = r.Next(0, 11);
                if (c <= 7)
                {
                    DGV1.Rows.Add(RandomName.GenFName());
                }
                if (c >= 8)
                {
                    DGV1.Rows.Add(RandomName.GetFNameF());
                }
                DGV1.Rows[i].HeaderCell.Value = $"{i+1}";
            }
            DGV1.TopLeftHeaderCell.Value = "Номер";
        }
    }
}
