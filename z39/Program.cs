using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer[] computers = new Computer[]
                {
                    new Computer("Model A", 16, 500),
                    new Computer("Model B", 8, 1000),
                    new Computer("Model C", 32, 2000),
                    new Computer("Model D", 4, 250)
                };

            // Вывод информации о каждом компьютере
            Console.WriteLine("Информация о каждом компьютере:");
            foreach (var computer in computers)
            {
                computer.ShowInfo();
            }

            // Вычисление общей стоимости всех моделей
            double totalPrice = Computer.CalculateTotalPrice(computers);
            Console.WriteLine($"\nОбщая стоимость всех моделей: {totalPrice} долларов");
            Console.ReadKey();
        }
    }
}
