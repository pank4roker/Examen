using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6
{
    class Employee
    {
        public string name;
        public string surname;
        public Employee() { }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public double CalcSalary(string position, int experience, double salary)
        {
            switch (position.ToLower())
            {
                case "менеджер":
                    salary += 20000;
                    break;
                case "разрабочик":
                    salary += 15000;
                    break;
                case "тестировщик":
                    salary += 10000;
                    break;
                default:
                    salary += 5000;
                    break;
            }

            return salary;

        }
        public double Tax(double salary)
        {
            double tax = 0.13;
            return salary * tax;
        }
        public void OutPut(string position, int experience,double salary)
        {
            Console.WriteLine($"{name};{surname};{CalcSalary(position,experience,salary)};{Tax(salary)}");
        }
    }
}
