using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z45
{
    class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override string ToString()
        {
            return $"Triangle (Sides: {SideA}, {SideB}, {SideC}) {Perimeter()} {Area()}";
        }
    }
}
