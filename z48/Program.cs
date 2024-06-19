using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace z48
{
    class Kupura
    {
    private string name;
    private int denomination;
    private int quantity;

    // Свойства
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                throw new ArgumentException("Название не может быть пустым.");
        }
    }

    public int Denomination
    {
        get { return denomination; }
        set
        {
            if (value > 0)
                denomination = value;
            else
                throw new ArgumentException("Номинал должен быть больше нуля.");
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value >= 0)
                quantity = value;
            else
                throw new ArgumentException("Количество не может быть отрицательным.");
        }
    }

    // Конструктор по умолчанию
    public Kupura() { }

    // Конструктор с параметрами
    public Kupura(string name, int denomination, int quantity)
    {
        Name = name;
        Denomination = denomination;
        Quantity = quantity;
    }

    // Метод для вывода информации о купюре
    public void Show()
    {
        Console.WriteLine($"Название: {Name}, Номинал: {Denomination}, Количество: {Quantity}");
    }

    // Метод для изменения количества купюр
    public void ChangeQuantity(int amount)
    {
        Quantity += amount;
    }

    // Метод для проверки достаточности суммы для оплаты
    public bool IsEnoughForPurchase(int cost)
    {
        return Denomination * Quantity >= cost;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов с помощью различных конструкторов
        Kupura kupura1 = new Kupura("Доллар", 100, 5);
        Kupura kupura2 = new Kupura("Евро", 50, 10);
        Kupura kupura3 = new Kupura("Рубль", 500, 3);

        // Вывод информации о купюрах
        kupura1.Show();
        kupura2.Show();
        kupura3.Show();

        // Изменение количества купюр
        kupura1.ChangeQuantity(2);
        kupura1.Show();

        // Проверка достаточности суммы для оплаты
        int cost = 400;
        Console.WriteLine(kupura1.IsEnoughForPurchase(cost) ? "Достаточно средств для оплаты." : "Недостаточно средств для оплаты.");

        // Пример ввода значений пользователем
        Console.WriteLine("Введите название купюры:");
        string userInputName = Console.ReadLine();

        Console.WriteLine("Введите номинал купюры:");
        int userInputDenomination;
        while (!int.TryParse(Console.ReadLine(), out userInputDenomination) || userInputDenomination <= 0)
        {
            Console.WriteLine("Введите корректное значение номинала:");
        }

        Console.WriteLine("Введите количество купюр:");
        int userInputQuantity;
        while (!int.TryParse(Console.ReadLine(), out userInputQuantity) || userInputQuantity < 0)
        {
            Console.WriteLine("Введите корректное количество:");
        }

        // Создание объекта на основе пользовательского ввода
        Kupura userKupura = new Kupura(userInputName, userInputDenomination, userInputQuantity);
        userKupura.Show();

        Console.ReadKey();
    }
}
}
