using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z39
{
    class Computer
    {
        /// <summary>
        /// Model with settings
        /// </summary>
        string model;
        public string Model { get => model; set => model = value; }
        /// <summary>
        /// Ram with settings
        /// </summary>
        int ram;
        public int Ram { get => (ram >= 2) & (ram <= 32) ? ram : 0; set => ram = value; }
        /// <summary>
        /// HDD with settings
        /// </summary>
        int hdd;
        public int Hdd { get => (hdd >= 200) & (hdd <= 2000) ? hdd : 0; set => hdd = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Computer() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="model"></param>
        /// <param name="ram"></param>
        /// <param name="hdd"></param>
        public Computer(string model, int ram, int hdd)
        {
            this.Model = model;
            this.Ram = ram;
            this.Hdd = hdd;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Model: {Model}\nRam: {Ram} gb\nHdd: {Hdd} gb\n");
        }
        public double CalculatePrice()
        {
            // Пример расчета стоимости
            // Стоимость = базовая стоимость + стоимость ОЗУ + стоимость жесткого диска
            double basePrice = 500.0;
            double ramPrice = 20.0 * ram; // 20 долларов за Гбайт ОЗУ
            double hddPrice = 0.1 * hdd; // 0.1 доллар за Гбайт жесткого диска

            return basePrice + ramPrice + hddPrice;
        }

        // Статический метод для вычисления общей стоимости всех моделей
        public static double CalculateTotalPrice(Computer[] computers)
        {
            double totalPrice = 0.0;
            foreach (var computer in computers)
            {
                totalPrice += computer.CalculatePrice();
            }
            return totalPrice;
        }

    }
}
