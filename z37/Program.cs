using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z37
{
    class Program
    {
        delegate double Square(double a, double b, double c);
        static void Main(string[] args)
        {
            Square sq = new Square(S);
            double result = sq.Invoke(5, 5, 5);
            Console.WriteLine(result);
            result = sq.Invoke(1,3,4);
            Console.WriteLine(result);
            result = sq.Invoke(7, 3, 4);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        static double S(double a, double b, double c)
        {
            double pper = (a + b + c) / 2;
            double area = pper * (pper - a) * (pper - b) * (pper - c);
            if (a + b > c || a + c > b || b + c > a)
            {
                return Math.Sqrt(area);
            }
            else
            {
                return 0;
            }
        }
    }
}
