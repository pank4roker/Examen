using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z17__
{
    class TVSet : ISwitchable
    {
        public void Off()
        {
            Console.WriteLine("Включение");
        }

        public void On()
        {
            Console.WriteLine("Выключение");
        }
    }
}
