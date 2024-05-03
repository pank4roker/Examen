using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 сторону: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 сторону: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1,side2);
            Console.WriteLine(rectangle.Area);
            Console.WriteLine(rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}
