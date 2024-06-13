using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figura = new Figure();

            Console.WriteLine("Введите количество параметров (1 - квадрат, 2 - прямоугольник, 3 - трапеция):");
            int paramCount = int.Parse(Console.ReadLine());

            switch (paramCount)
            {
                case 1:
                    Console.Write("Введите сторону квадрата: ");
                    double side = double.Parse(Console.ReadLine());
                    figura.ShowArea(side);
                    break;

                case 2:
                    Console.Write("Введите длину прямоугольника: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Введите ширину прямоугольника: ");
                    double width = double.Parse(Console.ReadLine());
                    figura.ShowArea(length, width);
                    break;

                case 3:
                    Console.Write("Введите основание 1 трапеции: ");
                    double base1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите основание 2 трапеции: ");
                    double base2 = double.Parse(Console.ReadLine());
                    Console.Write("Введите высоту трапеции: ");
                    double height = double.Parse(Console.ReadLine());
                    figura.ShowArea(base1, base2, height);
                    break;

                default:
                    Console.WriteLine("Некорректное количество параметров");
                    break;
            }

            Console.ReadLine();
        }
    }
}
