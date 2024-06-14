using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z35
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Реализация метода CompareTo для сортировки по имени
        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }

        // Переопределение метода ToString для удобного вывода информации о человеке
        public override string ToString()
        {
            return $"{Name}, {Age} лет";
        }
    }
}
