using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10
{
    class Plane:Vehicle
    {
        private double height;
        private int numberofPassengers;

        public Plane(double price, int speed, int yearofissue, int latitude, int longitude, double height, int numberofPassengers) : base(price, speed, yearofissue, latitude,longitude)
        {
            Height = height;
            NumberofPassengers = numberofPassengers;
        }
        public Plane() { }
        public double Height { get => height; set => height = value; }
        public int NumberofPassengers { get => numberofPassengers; set => numberofPassengers = value; }
        public override void OutPut()
        {
            base.OutPut();
            Console.Write($"Высота: {height};Количество пассажиров: {numberofPassengers}");
        }
    }
}
