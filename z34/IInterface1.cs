using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z34
{
    interface IInterface1
    {
        void Method1();
    }
    interface IInterface2 : IInterface1
    {
        void Method2();
    }
    interface IInterface3 : IInterface2
    {
        void Method3();
    }
}
