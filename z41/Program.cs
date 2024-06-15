using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра Point с координатами типа int
            Point<int, int> intPoint = new Point<int, int>(10, 20);
            intPoint.Info();

            // Создание экземпляра Point с координатами типа double
            Point<double, double> doublePoint = new Point<double, double>(10.5, 20.5);
            doublePoint.Info();

            // Создание экземпляра Point с координатами типа string
            Point<string, string> stringPoint = new Point<string, string>("10", "20");
            stringPoint.Info();
            Console.ReadKey();
        }
    }
}
