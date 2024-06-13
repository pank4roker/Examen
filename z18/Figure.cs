using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z17
{
    class Figure
    {
        // Перегруженный метод ShowArea для квадрата
        public void ShowArea(double side)
        {
            double area = side * side;
            Console.WriteLine("Фигура: Квадрат");
            Console.WriteLine($"Площадь: {area}");
        }

        // Перегруженный метод ShowArea для прямоугольника
        public void ShowArea(double length, double width)
        {
            double area = length * width;
            Console.WriteLine("Фигура: Прямоугольник");
            Console.WriteLine($"Площадь: {area}");
        }

        // Перегруженный метод ShowArea для трапеции
        public void ShowArea(double base1, double base2, double height)
        {
            double area = 0.5 * (base1 + base2) * height;
            Console.WriteLine("Фигура: Трапеция");
            Console.WriteLine($"Площадь: {area}");
        }
    }
}
