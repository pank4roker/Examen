using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Converter
    {
        double usd;
        double eur;
        double rub;

        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }
        public Converter() { }

        public double Usd { get => usd; set => usd = value; }
        public double Eur { get => eur; set => eur = value; }
        public double Rub { get => rub; set => rub = value; }

        public void Exchange(double kursrub,double kursusd,double kurseur)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine(" 1. Обмен USD в BYN");
                Console.WriteLine(" 2. Обмен RUB в BYN");
                Console.WriteLine(" 3. Обмен EUR в BYN");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" 4. Выйти");
                Console.ResetColor();
                double sum;
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        sum = Usd / kursusd;
                        Console.WriteLine($"BYN по отношению к USD:{sum}");
                        break;
                    case '2':
                        sum = Rub/ kursrub;
                        Console.WriteLine($"BYN по отношению к RUB:{sum}");
                        break;
                    case '3':
                        sum = Eur / kurseur;
                        Console.WriteLine($"BYN по отношению к EUR:{sum}");
                        break;
                    case '4':return;
                    default: Console.Write("Вы ввели неправильную цифру"); break;
                }
            }
        }
        public void ExchangerBYN(double byn, double kursrub, double kursusd, double kurseur)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine(" 1. Обмен BYN в USD");
                Console.WriteLine(" 2. Обмен BYN в RUB");
                Console.WriteLine(" 3. Обмен BYN в EUR");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" 4. Выйти");
                Console.ResetColor();
                double sum;
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        sum = byn * kursusd;
                        Console.WriteLine($"USD по отношению к BYN:{sum}");
                        break;
                    case '2':
                        sum =  byn * kursrub;
                        Console.WriteLine($"RUB по отношению к BYN:{sum}");
                        break;
                    case '3':
                        sum =  byn * kurseur;
                        Console.WriteLine($"EUR по отношению к BYN:{sum}");
                        break;
                    case '4': return;
                    default: Console.Write("Вы ввели неправильную цифру"); break;
                }
            }
        }

        static public Converter InPut()
        {
            Console.Write("Введите количество USD: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество RUB: ");
            double rub = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество EUR: ");
            double eur = Convert.ToDouble(Console.ReadLine());
            return new Converter(usd, rub, eur);
        }
    }
}
