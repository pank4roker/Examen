using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Converter> list = new List<Converter>();
            Converter converter = Converter.InPut();
            list.Add(converter); 
            Console.Write("Введите курс BYN к RUB: ");
            double kursrub = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите курс BYN к USD: ");
            double kursusd = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите курс BYN к EUR: ");
            double kurseur = Convert.ToDouble(Console.ReadLine());
            while (true) 
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine(" 1. из BYN в одну из указанных валют");
                Console.WriteLine(" 2. из указанных валют в BYN");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" 3. Выйти");
                Console.ResetColor();
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        Console.WriteLine("Введите количество BYN: ");
                        double byn = Convert.ToDouble(Console.ReadLine());
                        converter.ExchangerBYN(byn, kursrub, kursusd, kurseur);
                        break;
                    case '2':
                        converter.Exchange(kursrub, kursusd, kurseur);  
                        break;
                    case '3': return;
                    default: Console.Write("Вы ввели неправильную цифру"); break;
                }
                Console.ReadLine();
            }
        }
      
    }
}
