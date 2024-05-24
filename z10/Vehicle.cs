using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10
{
    abstract class Vehicle
    {
        private int longitude;
        private double price;
        private int speed;
        private int yearofissue;
        private int latitude;

        public Vehicle() { }

        protected Vehicle(double price, int speed, int yearofissue, int latitude, int longitude)
        {
            Price = price;
            Speed = speed;
            Yearofissue = yearofissue;
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Price { get => price; set => price = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Yearofissue { get => yearofissue; set => yearofissue = value; }
        public int Latitude { get => latitude; set => latitude = value; }
        public int Longitude { get => longitude; set => longitude = value; }

        public virtual void OutPut()
        {
            Console.WriteLine($"Широта: {longitude};Долгота: {latitude};Цена: {price};Скорсть: {speed};Год производства: {yearofissue};");
        }
    }
}
