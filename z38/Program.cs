using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание массива объектов Product
            Product[] products = new Product[]
            {
                new Product("Молоко", "Производитель А", 50.0, 10, 100),
                new Product("Хлеб", "Производитель Б", 20.0, 5, 200),
                new Product("Сыр", "Производитель В", 150.0, 30, 50),
                new Product("Молоко", "Производитель Г", 45.0, 8, 80),
                new Product("Йогурт", "Производитель Д", 60.0, 15, 70)
            };

            // Список товаров для заданного наименования
            string searchName = "Молоко";
            Console.WriteLine($"\nСписок товаров с наименованием \"{searchName}\":");
            foreach (var product in products)
            {
                if (product.Name == searchName)
                {
                    product.GetProductInfo();
                }
            }

            // Список товаров для заданного наименования, цена которых не превышает указанной
            double maxPrice = 50.0;
            Console.WriteLine($"\nСписок товаров с наименованием \"{searchName}\", цена которых не превышает {maxPrice}:");
            foreach (var product in products)
            {
                if (product.Name == searchName && product.Price <= maxPrice)
                {
                    product.GetProductInfo();
                }
            }

            // Список товаров, срок хранения которых больше заданного
            int minShelfLife = 10;
            Console.WriteLine($"\nСписок товаров, срок хранения которых больше {minShelfLife} дней:");
            foreach (var product in products)
            {
                if (product.ShelfLife > minShelfLife)
                {
                    product.GetProductInfo();
                }
            }
        }
    }
}
