using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10
{
    class Car:Vehicle
    {
        public Car(double price, int speed, int yearofissue, int latitude, int longitude) : base(price, speed, yearofissue, latitude, longitude)
        {
        }
        public Car() { }
        public override void OutPut()
        {
            base.OutPut();
        }
    }
}
