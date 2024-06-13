using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z17__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> switchables = new List<ISwitchable>();
            TVSet tVSet = new TVSet();
            PersonalComputer personalComputer = new PersonalComputer();
            switchables.Add(tVSet);
            switchables.Add(personalComputer);
            foreach (var elem in switchables)
            {
                if (elem is TVSet)
                {
                    Console.WriteLine("Televisor");
                    elem.On();
                    elem.Off();
                }
                else
                {
                    Console.WriteLine("PC");
                    elem.On();
                    elem.Off();
                }
            }
            Console.ReadLine();
        }
    }
}
