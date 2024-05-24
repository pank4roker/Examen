using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10
{
    class Ship:Vehicle
    {
        private int numberofPassengers;
        private string port;

        public Ship(double price, int speed, int yearofissue, int latitude, int longitude, int numberofPassengers, string port):base(price,speed,yearofissue, latitude, longitude)
        {
            NumberofPassengers = numberofPassengers;
            Port = port;
        }
        public Ship() { }
        public int NumberofPassengers { get => numberofPassengers; set => numberofPassengers = value; }
        public string Port { get => port; set => port = value; }
        public override void OutPut()
        {
            base.OutPut();
            Console.Write($"Количество пассажиов: {numberofPassengers};Порт приписки: {port}");
        }
    }
}
