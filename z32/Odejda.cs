using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z32
{
    class Odejda : Goods
    {
        private int count;
        private int size;
        private double massa;
        private string color;

        public Odejda() { }
        public Odejda(string name, double price, int count, int size, double massa, string color) : base(name, price)
        {
            Count = count;
            Size = size;
            Massa = massa;
            Color = color;
        }

        public int Count { get => count; set => count = value; }
        public int Size { get => size; set => size = value; }
        public double Massa { get => massa; set => massa = value; }
        public string Color { get => color; set => color = value; }
        public override double CalcSum()
        {
            return Price * Count;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{Count};{Size};{Massa};{Color};Общая стоимость: {CalcSum()}");
        }
    }
}
