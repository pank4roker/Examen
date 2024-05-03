using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Rectangle
    {
        double side1, side2;
        public double Perimeter { get; }//=> 2 * (side1 + side2);
        public double Area { get; } //=> side1 * side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            Perimeter = PerimeterCalculator();
            Area = AreaCalculator();
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
       

    }
}
