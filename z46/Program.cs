using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z46
{
    // Интерфейс для преобразований чисел типа double
    public interface ICalculation
    {
        double Perform(double number);
    }

    // Класс для сложения числа с заданной величиной
    public class Add : ICalculation
    {
        private double valueToAdd;

        public Add(double valueToAdd)
        {
            this.valueToAdd = valueToAdd;
        }

        public double Perform(double number)
        {
            return number + valueToAdd;
        }
    }

    // Класс для умножения числа на заданный коэффициент
    public class Multiply : ICalculation
    {
        private double multiplier;

        public Multiply(double multiplier)
        {
            this.multiplier = multiplier;
        }

        public double Perform(double number)
        {
            return number * multiplier;
        }
    }

    class Program
    {
        // Метод для последовательного применения двух преобразований к числу
        public static double Calculate(double number, ICalculation transformation1, ICalculation transformation2)
        {
            double result = transformation1.Perform(number);
            result = transformation2.Perform(result);
            return result;
        }

        static void Main(string[] args)
        {
            // Пример использования

            // Создание преобразований
            ICalculation add = new Add(5);         // Добавляет 5 к числу
            ICalculation multiply = new Multiply(2); // Умножает число на 2

            // Исходное число
            double number = 10;

            // Применение преобразований
            double result = Calculate(number, add, multiply);

            // Вывод результата
            Console.WriteLine($"Initial number: {number}");
            Console.WriteLine($"After adding 5: {add.Perform(number)}");
            Console.WriteLine($"After multiplying by 2: {multiply.Perform(add.Perform(number))}");
            Console.WriteLine($"Final result: {result}");
        }
    }
}
