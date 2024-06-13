using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string value = Console.ReadLine();
            Printer defaultPrinter = new Printer();
            Printer redPrinter = new RedPrinter();
            defaultPrinter.Print(value);
            redPrinter.Print(value);
            Console.ReadLine();
        }
    }
}
