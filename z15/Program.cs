using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z15
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.ShowInterfaceA();
            myClass.ShowInterfaceB();
            myClass.ShowInterfaceC();
            Console.ReadLine();
        }
    }
}
