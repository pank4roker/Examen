using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(Point.InPut(),Point.InPut(),Point.InPut());
            figure.Perimetr();
            Figure figure1 = new Figure(Point.InPut(), Point.InPut(), Point.InPut(), Point.InPut());
            figure1.Perimetr();
            Figure figure2 = new Figure(Point.InPut(), Point.InPut(), Point.InPut(), Point.InPut(), Point.InPut());
            figure2.Perimetr();
            Console.ReadLine();
        }
    }
}
