using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z43
{
    class Triangle<T, P, R>
    {
        T a;
        P b;
        R c;

        public Triangle() { }
        public Triangle(T a, P b, R c)
        {
            if ((dynamic)a + b > c && (dynamic)a + c > b && (dynamic)b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else { Console.WriteLine("Треугольник с такими сторонами не существет"); }
        }

        public T A { get => a; set => a = value; }
        public P B { get => b; set => b = value; }
        public R C { get => c; set => c = value; }
        public void ShowInfo()
        {
            Console.WriteLine($"Треугольник имеет стороны: A - {A}; B - {B}; C - {C}.");
        }
        public double Area()
        {

            double s = ((dynamic)A + B + C) / 2;

            double area = Math.Sqrt(s * ((dynamic)s - A) * ((dynamic)s - B) * ((dynamic)s - C));

            return area;
        }
    }
}
