using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z15
{
    class MyClass : InterfaceC
    {
        public void ShowInterfaceA()
        {
            Console.WriteLine("ShowInterfaceA");
        }

        public void ShowInterfaceB()
        {
            Console.WriteLine("ShowInterfaceB");
        }

        public void ShowInterfaceC()
        {
            Console.WriteLine("ShowInterfaceC");
        }
    }
}
