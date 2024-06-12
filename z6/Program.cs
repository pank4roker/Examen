using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите должность: ");
            string position = Console.ReadLine();

            Console.Write("Введите стаж (в годах): ");
            int experience = int.Parse(Console.ReadLine());

            Console.Write("Введите зарплату: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee employee = new Employee(firstName, lastName);

            employee.OutPut(position, experience,salary);
           
            Console.ReadLine();
        }
    }
}
