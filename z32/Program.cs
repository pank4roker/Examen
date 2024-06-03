using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z32
{
    class Program
    {
        static void Main(string[] args)
        {
            Obuv obuv = new Obuv("Кроксы", 100, 20, 42, 250, "Розовые");
            Odejda odejda = new Odejda("Платье",150,43,56,500,"Белое");
            Posuda posuda = new Posuda("Чашки",20,100,20,200,"Желтое");
            obuv.Print();
            odejda.Print();
            posuda.Print();
            Console.ReadLine();
        }
    }
}
