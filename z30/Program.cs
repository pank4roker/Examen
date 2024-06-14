using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z30
{
    class Tovar
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Tovar(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Calc()
        {
            Console.WriteLine($"Товар: {Name}, Цена за единицу: {Price}");
        }
    }

    // Класс Book, наследующий от Tovar
    class Book : Tovar
    {
        public int Kvo { get; set; }

        public Book(string name, double price, int kvo) : base(name, price)
        {
            Kvo = kvo;
        }

        public override void Calc()
        {
            double total = Price * Kvo;
            Console.WriteLine($"Книга: {Name}, Цена за книгу: {Price}, Количество: {Kvo}, Общая стоимость: {total}");
        }
    }

    // Класс Pen, наследующий от Tovar
    class Pen : Tovar
    {
        public int Kvo { get; set; }

        public Pen(string name, double price, int kvo) : base(name, price)
        {
            Kvo = kvo;
        }

        public override void Calc()
        {
            double total = Price * Kvo;
            Console.WriteLine($"Ручка: {Name}, Цена за ручку: {Price}, Количество: {Kvo}, Общая стоимость: {total}");
        }
    }

    // Класс Candy, наследующий от Tovar
    class Candy : Tovar
    {
        public double Ves { get; set; }

        public Candy(string name, double price, double ves) : base(name, price)
        {
            Ves = ves;
        }

        public override void Calc()
        {
            double total = Price * Ves;
            Console.WriteLine($"Конфеты: {Name}, Цена за килограмм: {Price}, Вес: {Ves} кг, Общая стоимость: {total}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляры классов
            Book book = new Book("C# Programming", 50, 3);
            Pen pen = new Pen("Blue Pen", 1.5, 10);
            Candy candy = new Candy("Chocolate Candy", 20, 2.5);

            // Демонстрация работы метода Calc
            book.Calc();
            pen.Calc();
            candy.Calc();

            Console.ReadLine();
        }
    }
}
