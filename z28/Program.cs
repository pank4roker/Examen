using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z28
{
    class Program
    {
        static void Main(string[] args)
        {
            Tour tour = new Tour();
            tour.TourCalc();
            tour.TourCalc("fdfd");
            tour.TourCalc("fdfd",50);
            Console.ReadKey();
        }
    }
}
