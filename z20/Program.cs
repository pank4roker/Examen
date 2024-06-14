using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z20
{
    struct Book
    {
        public Book(string name, string fIO, int yearOfPublication, int countPages)
        {
            Name = name;
            FIO = fIO;
            YearOfPublication = yearOfPublication;
            CountPages = countPages;
        }

        public string Name { get; set; }
        public string FIO { get; set; }
        public int YearOfPublication { get; set; }
        public int CountPages { get; set; }
        public void OutPut()
        {
            Console.WriteLine($"{Name};{FIO};{YearOfPublication};{CountPages}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество книг(n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите данные для книги {i + 1}:");

                Console.Write("Название: ");
                string name = Console.ReadLine();

                Console.Write("Автор: ");
                string author = Console.ReadLine();

                Console.Write("Год издания: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Количество страниц: ");
                int pages = Convert.ToInt32(Console.ReadLine());

                books[i] = new Book(name, author, year, pages);
            }

            Console.WriteLine("\nИнформация о всех книгах:");

            foreach (var book in books)
            {
                book.OutPut();
            }

            // Для чтения ввода пользователя перед завершением программы
            Console.ReadLine();
        }
    }
}
