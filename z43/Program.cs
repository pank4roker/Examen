using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle<int, uint, double> triangle = new Triangle<int, uint, double>(3, 3, 3.0);
            triangle.ShowInfo();
            Console.WriteLine($"Площадь трегуольника равна - {triangle.Area():f2}");
            Triangle<int, uint, double> triangle1 = new Triangle<int, uint, double>(7, 2, 1);
            if (triangle1.A + triangle1.B > triangle1.C &&
                triangle1.A + triangle1.C > triangle1.B &&
                triangle1.B + triangle1.C > triangle1.A)
            {
                triangle1.ShowInfo();
                Console.WriteLine($"Площадь трегуольника равна - {triangle1.Area():f2}");
            }
            Console.ReadKey();
        }
    }
}
