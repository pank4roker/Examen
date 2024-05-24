using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1000,120,2022,55,67);
            car.OutPut();
            Plane plane = new Plane(450000,750,2023,100,130,1000,54);
            plane.OutPut();
            Ship ship = new Ship(100000,350,2000,50,47,100,"Владивосток");
            ship.OutPut();
        }
    }
}
