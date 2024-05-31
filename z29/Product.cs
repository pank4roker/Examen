using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z29
{
    class Product
    {
        string name;
        double price;
        int count;
        public Product() { }

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public string Name { get => (name != "")?name:"Неизвестно"; set => name = value; }
        public double Price { get => (price >= 1 && price<=20)?price:0; set => price = value; }
        public int Count { get => (count>=0 && count <=10)?count:0; set => count = value; }

        public void OutPut()
        {
            Console.WriteLine($"{Name}\n{Price}\n{Count}");
        }
        public double Sum()
        {
            return Price * Count;
        }

    }
}
