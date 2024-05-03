using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Figure
    {
        public double Perimeter { set; get; }
        public Figure(Point a,Point b,Point c) 
        {
            Perimeter = LengthL(a, b) + LengthL(b, c) + LengthL(c, a);
        }
        public Figure(Point a,Point b,Point c,Point d) 
        {
            Perimeter = LengthL(a, b) + LengthL(b, c) + LengthL(c, d) + LengthL(d,a);
        }
        public Figure(Point a, Point b, Point c, Point d,Point e) 
        {
            Perimeter = LengthL(a, b) + LengthL(b, c) + LengthL(c, d) + LengthL(d, e) + LengthL(e,a);
        }
        public double LengthL(Point a,Point b)
        {
            return Math.Sqrt(Math.Pow(b.X-a.X,2)+Math.Pow(b.Y-a.Y,2));
        }
        public void Perimetr()
        {
            Console.WriteLine($"Perimetr={Perimeter}");
        }
    }
}
