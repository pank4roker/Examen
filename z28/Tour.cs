using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z28
{
    class Tour
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public  int Days { get; set; }
        public Tour() { }
        public void TourCalc() 
        {
            Name = "Минское";
            Price = 0;
            Console.WriteLine($"{Name}{Price}");
        }
        public void TourCalc(string name)
        {
            Name = name;
            Price = 50;
            Days = 1;
            Console.WriteLine($"{Name}{Price}{Days}");
        }
        public void TourCalc(string name,int days)
        {
            Name = name;
            Days = days;
            Price = 50 * days;
            Console.WriteLine($"{Name}{Price}{Days}");
        }


    }
}
