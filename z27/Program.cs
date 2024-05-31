using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();
            Console.WriteLine("\nTask1");
            colors.Add("Красный");
            colors.Add("Розовый");
            colors.Add("Синий");
            colors.Add("Белый");
            OutPut(colors);
            Console.WriteLine("\nTask2");
            OutPutInCapitals(colors);
            Console.WriteLine("\nTask3");
            Console.WriteLine(CountElements(colors));
            Console.WriteLine("\nTask4");
            colors.Insert(4,"Фиолетовый");
            OutPut(colors);
            Console.WriteLine("\nTask5");
            colors.Insert(0, "Черный");
            OutPut(colors);
            Console.WriteLine("\nTask6");
            colors.RemoveAt(3);
            OutPut(colors);
            Console.WriteLine("\nTask7");
            colors.Sort();
            OutPut(colors);
            Console.ReadKey();
            
        }
        /// <summary>
        /// выведите содержимое коллекции на экран
        /// </summary>
        /// <param name="colors"></param>
        public static void OutPut(List<string> colors)
        {
            foreach (var elem in colors)
            {
                Console.WriteLine($"{elem}");
            }
        }
        /// <summary>
        /// преобразуйте все буквы элементов в прописные
        /// </summary>
        /// <param name="colors"></param>
        public static void OutPutInCapitals(List<string> colors)
        {
            foreach (var elem in colors)
            {
                Console.WriteLine($"{elem.ToUpper()}");
            }
        }
        /// <summary>
        /// определите текущее количество элементов коллекции;
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>
        public static int CountElements(List<string> colors )
        {
            return colors.Count();
        }
        
    }
}
