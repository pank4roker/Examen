using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z47
{
    class Zakaz
    {
        public string Fam { get; set; }
        public int Size { get; set; }
        public string Comfort { get; set; }

        public Zakaz()
        {
            Fam = "Неизвестно";
            Size = 0;
            Comfort = "Стандарт";
        }

        public Zakaz(string fam)
        {
            Fam = fam;
            Size = 0;
            Comfort = "Стандарт";
        }

        public Zakaz(string fam, int size)
        {
            Fam = fam;
            Size = size;
            Comfort = "Стандарт";
        }

        public Zakaz(string fam, int size, string comfort)
        {
            Fam = fam;
            Size = size;
            Comfort = comfort;
        }

        public void Show()
        {
            Console.WriteLine($"Фамилия: {Fam}, Количество мест: {Size}, Комфорт: {Comfort}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Zakaz> zakazi = new List<Zakaz>();

            while (true)
            {
                Console.WriteLine("Введите фамилию (или 'Q' для завершения): ");
                string fam = Console.ReadLine();
                if (fam.ToUpper() == "Q")
                    break;

                Console.WriteLine("Введите количество мест: ");
                int size = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите комфортность: ");
                string comfort = Console.ReadLine();

                Zakaz zakaz = new Zakaz(fam, size, comfort);
                zakazi.Add(zakaz);
            }

            Console.WriteLine("\nВсе заказы:");
            foreach (var zakaz in zakazi)
            {
                zakaz.Show();
            }
        }
    }
}
