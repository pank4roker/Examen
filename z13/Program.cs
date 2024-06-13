using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace z13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AbstractHandler> handlers = new List<AbstractHandler>();
            while (true)
            {
                Write("Enter file format/if you want to close the console, write the (exit): ");
                string format = ReadLine();
                WriteLine();
                switch (format.ToLower())
                {
                    case "xml":
                        XMLHandler handler = new XMLHandler();
                        handler.Open();
                        handler.Create();
                        handler.Change();
                        handler.Save();
                        WriteLine();
                        break;
                    case "txt":
                        TXTHandler handler1 = new TXTHandler();
                        handler1.Open();
                        handler1.Create();
                        handler1.Change();
                        handler1.Save();
                        WriteLine();
                        break;
                    case "doc":
                        DOCHandler handler2 = new DOCHandler();
                        handler2.Open();
                        handler2.Create();
                        handler2.Change();
                        handler2.Save();
                        WriteLine();
                        break;
                    case "exit": return;
                    default:
                        WriteLine("You entered wrong format!");
                        break;
                }

            }
            ReadKey();
        }
    }
}
