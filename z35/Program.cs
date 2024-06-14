using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z35
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>
            {
                new Person("Янна", 28),
                new Person("Борис", 35),
                new Person("Вктор", 23),
                new Person("алина", 31)
            };

            // Сортировка списка по имени
            peopleList.Sort();

            // Вывод отсортированного списка
            Console.WriteLine("Отсортированный список людей:");
            foreach (var person in peopleList)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}
