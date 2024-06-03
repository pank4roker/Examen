using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace z32
{
    abstract class Goods
    {
        private string name;
        private double price;
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public Goods() { }
        public Goods(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract double CalcSum();
        public virtual void Print() 
        {
            Console.Write($"{Name};{Price};");
        }

    }
}
