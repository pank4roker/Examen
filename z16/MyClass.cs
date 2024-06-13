using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z16
{
    class MyClass : IFunc
    {
        public int X { get; set; }
        public MyClass() { }
        public MyClass(int x)
        {
            X = x;
        }
        public double Pi()
        {
            return Math.PI;
        }
        public int Number()
        {
           return X;
        }
        public double Sq()
        {
            return Math.Sqrt(X);
        }
        public double Root()
        {
           return Math.Pow(X, 2);
        }
        public void Info()
        {
            Console.WriteLine($"{Number()}\n{Pi()}\n{Root()}\n{Sq()}");
        }

    }
}
