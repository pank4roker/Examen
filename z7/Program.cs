using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер счета: ");
            int account = int.Parse(Console.ReadLine());

            Console.Write("Введите имя клиента: ");
            string customer = Console.ReadLine();

            Console.Write("Введите имя поставщика: ");
            string provider = Console.ReadLine();

            Invoice invoice = new Invoice(account, customer, provider);
            Console.Write("Введите наименование товара: ");
            string article = Console.ReadLine();

            Console.Write("Введите количество товара: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Введите цену за единицу товара: ");
            double pricePerUnit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите налоговую ставку (например, 1.2 для 20%): ");
            double nds = Convert.ToDouble(Console.ReadLine());
            invoice.Tovar(article, quantity);
            Console.Write(invoice.PriceWithout(pricePerUnit));
            Console.Write(invoice.PriceWith(pricePerUnit,nds));
            Console.ReadLine();
        }
    }
}
