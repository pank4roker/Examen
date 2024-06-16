using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Disk disk = new Disk(5);

            // Вывод информации о фигурах
            Console.WriteLine(triangle.ToString());
            Console.WriteLine(disk.ToString());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
