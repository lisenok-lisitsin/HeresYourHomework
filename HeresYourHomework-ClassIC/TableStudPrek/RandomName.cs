using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableStudPrek
{
    public class RandomName
    {
        private static Random random = new Random();

        private static string[] firstNames = { "Иван", "Родион", "Святослав", "Фёдор", "Михаил", "Максим", "Сергей", "Артём", "Андрей", "Владимир", "Ярослав", "Валентин", "Геннадий", "Игорь", "Олег", "Руслан", "Герасим", "Ярополк", "Бекмек" };
        private static string[] lastNames = { "Рахматов", "Пражин", "Прядко", "Филипов", "Васильев", "Эсмиральдов", "Кац", "Демошенко", "Пономарёв", "Кравченко", "Ягудин", "Маршаков", "Славянских" };
        private static string[] midNames = { "И.", "В.", "Б.", "Г.", "А.", "С.", "Р." };

        private static string[] firstNamesF = { "Жанна", "Констанция", "Екатерина", "Анастасия", "Марьяна", "Мария", "Александра", "Евгения", "Ирина", "Елена", "Светлана", "Катерина" };
        private static string[] lastNamesF = { "Ибрагимова", "Сергеева", "Тролл", "Шпицманн", "Велинская", "Рыбникова" };
        private static string[] midNamesF = { "С.", "Д.", "Е.", "Г.", "М.", "И.", "К.", "Т.", "У.", "В." };

        private static string[] sorted;

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

        public static string[] SortRName(int num1)
        {
            Random r = new Random();
            sorted = new string[num1];
            int temp;
            for (int i = 0; i < num1; i++)
            {
                temp = r.Next(0, 101);
                if (temp <= 75)
                {
                    string g = RandomName.GenFName();
                    sorted[i] = g;
                }
                if (temp >= 76)
                {
                    string g = RandomName.GetFNameF();
                    sorted[i] = g;
                }
            }
            Array.Sort(sorted);
            return sorted;
        }
    }
}
