using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Выберете доступный цвет:");
            foreach (Pattern.Colors colors in Enum.GetValues(typeof(Pattern.Colors)))
            {
                Console.WriteLine($"{(int)colors} - {colors}");
            }
            Console.WriteLine("Введите цифру цвета:");
            int color = int.Parse(Console.ReadLine());
            Pattern.Print(stroka, color);
            Console.ReadLine();
        }
    }
}
