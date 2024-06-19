using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z38
{
    class Product
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public int ShelfLife { get; set; } // Срок хранения в днях
        public int Quantity { get; set; }

        // Конструктор для инициализации полей
        public Product(string name, string manufacturer, double price, int shelfLife, int quantity)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            ShelfLife = shelfLife;
            Quantity = quantity;
        }

        // Метод для вывода информации о продукте
        public void GetProductInfo()
        {
            Console.WriteLine($"Наименование: {Name}, Производитель: {Manufacturer}, Цена: {Price}, Срок хранения: {ShelfLife} дней, Количество: {Quantity}");
        }
    }
}
