using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z50
{
    class DateClass
    {
        private DateTime data;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public DateClass()
        {
            data = DateTime.Now;
        }

        /// <summary>
        /// Конструктор с параметрами (год, месяц, день)
        /// </summary>
        /// <param name="year">Год</param>
        /// <param name="month">Месяц</param>
        /// <param name="day">День</param>
        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }

        /// <summary>
        /// Свойство для доступа к полю data
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Метод для вычисления даты предыдущего дня
        /// </summary>
        /// <returns>Дата предыдущего дня</returns>
        public DateTime PreviousDay()
        {
            return data.AddDays(-1);
        }

        /// <summary>
        /// Метод для вычисления даты следующего дня
        /// </summary>
        /// <returns>Дата следующего дня</returns>
        public DateTime NextDay()
        {
            return data.AddDays(1);
        }

        /// <summary>
        /// Метод для вывода информации о дате
        /// </summary>
        public void ShowDate()
        {
            Console.WriteLine($"Дата: {data.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных с клавиатуры
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            // Создание объекта с использованием конструктора с параметрами
            DateClass date = new DateClass(year, month, day);

            // Вывод информации о дате
            date.ShowDate();

            // Вычисление и вывод даты предыдущего дня
            DateTime previousDay = date.PreviousDay();
            Console.WriteLine($"Предыдущий день: {previousDay.ToShortDateString()}");

            // Вычисление и вывод даты следующего дня
            DateTime nextDay = date.NextDay();
            Console.WriteLine($"Следующий день: {nextDay.ToShortDateString()}");

            Console.ReadKey();
        }
    }
}
