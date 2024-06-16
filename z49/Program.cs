using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z49
{
    class Point
    {
        private double x;
        private double y;

        // Статические поля для учета количества точек в каждой координатной четверти и общего количества точек
        private static int countFirstQuadrant = 0;
        private static int countSecondQuadrant = 0;
        private static int countThirdQuadrant = 0;
        private static int countFourthQuadrant = 0;
        private static int totalCount = 0;

        // Конструктор с параметрами
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            totalCount++;
            UpdateQuadrantCount();
        }

        // Метод для вывода координат точки
        public void ShowCoordinates()
        {
            Console.WriteLine($"Point coordinates: ({x}, {y})");
        }

        // Статический метод для вывода количества точек в каждой координатной четверти и общего количества точек
        public static void ShowPointsCount()
        {
            Console.WriteLine($"First Quadrant: {countFirstQuadrant}");
            Console.WriteLine($"Second Quadrant: {countSecondQuadrant}");
            Console.WriteLine($"Third Quadrant: {countThirdQuadrant}");
            Console.WriteLine($"Fourth Quadrant: {countFourthQuadrant}");
            Console.WriteLine($"Total Points: {totalCount}");
        }

        // Метод для обновления счетчика точек в зависимости от координат
        private void UpdateQuadrantCount()
        {
            if (x > 0 && y > 0)
            {
                countFirstQuadrant++;
            }
            else if (x < 0 && y > 0)
            {
                countSecondQuadrant++;
            }
            else if (x < 0 && y < 0)
            {
                countThirdQuadrant++;
            }
            else if (x > 0 && y < 0)
            {
                countFourthQuadrant++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание нескольких точек
            Point point1 = new Point(3, 4);
            Point point2 = new Point(-5, 7);
            Point point3 = new Point(-2, -8);
            Point point4 = new Point(6, -1);
            Point point5 = new Point(0, 0);

            // Вывод координат каждой точки
            point1.ShowCoordinates();
            point2.ShowCoordinates();
            point3.ShowCoordinates();
            point4.ShowCoordinates();
            point5.ShowCoordinates();

            // Вывод количества точек в каждой координатной четверти и общего количества точек
            Point.ShowPointsCount();

            Console.ReadKey();
        }
    }
}
