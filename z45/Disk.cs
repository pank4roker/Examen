using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z45
{
    class Disk : IShape
    {
        public double Radius { get; }

        public Disk(double radius)
        {
            Radius = radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Disk (Radius: {Radius}) {Perimeter()} {Area()}";
        }
    }
}
