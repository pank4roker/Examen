using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z
{
    static class Pattern
    {
        public enum Colors
        {
            Black,
            Blue,
            Green,
            Yellow,
            Red,
            Magenta,
            Cyan,
            White
        }
        public static void Print(string stroka, int color)
        {
            switch ((Colors)color)
            {
                case Colors.Black:
                    Console.ForegroundColor = ConsoleColor.Black; break;
                case Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue; break;
                case Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green; break;
                case Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow; break;
                case Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red; break;
                case Colors.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta; break;
                case Colors.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan; break;
                case Colors.White:
                    Console.ForegroundColor = ConsoleColor.White; break;
            }
            Console.Write(stroka);

        }
    }
}
