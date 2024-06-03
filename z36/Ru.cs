using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z36
{
    class Ru : People
    {
        public Ru() { }
        public Ru(string name):base(name)
        {
           
        }
        public override void SayHallo()
        {
            Console.WriteLine($"Привет {Name}");
        }
    }
}
