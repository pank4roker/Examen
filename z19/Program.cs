using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основные арифметические операции:");

            int num1 = 5;
            int num2 = 5;

            Console.WriteLine($"{num1} + {num2} = {Calculator.Add(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {Calculator.Sub(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {Calculator.Mul(num1, num2)}");
            if (num1 == 0)
            {
                Console.WriteLine("На ноль делить нельзя");

            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = {Calculator.Div(num1, num2)}");
            }
            // Для чтения ввода пользователя перед завершением программы
            Console.ReadLine();

        }
    }
}
