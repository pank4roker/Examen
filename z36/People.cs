using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z36
{
    abstract class People
    {
        public People() { }
        public People(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public abstract void SayHallo();
    }
}
