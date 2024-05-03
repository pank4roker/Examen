using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Point
    {
        int x, y;
        string name;

        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        public Point() { }

        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
        static public Point InPut()
        {
            Console.Write("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название точки: ");
            string name = Console.ReadLine();
            return new Point(x,y,name);
        }
    }
}
