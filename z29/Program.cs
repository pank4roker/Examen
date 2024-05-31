using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product product = new Product("Стулья", 10, 5);
            products.Add(product);
            product.OutPut();
            Console.WriteLine(product.Sum());
            Product product1 = new Product("Столы", 15, 10);
            products.Add(product1);
            product1.OutPut();
            Console.WriteLine(product1.Sum());
            double sum = 0;
            foreach(var elem in products)
            {
               sum += elem.Sum();
            }
            Console.Write($"Общая стоимость заказа: {sum}");
            Console.WriteLine();
            Console.ReadKey();
        }
     
    }
}
