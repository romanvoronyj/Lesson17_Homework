using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_Homework_Task3
{
    /*Створіть чотири лямбда оператора для виконання арифметичних дій: (Add - додавання, Sub - віднімання, Mul - множення, Div - розподіл). 
     * Кожен лямбда оператор повинен приймати два аргументи і повертати результат обчислення. Лямбда оператор ділення повинен робити перевірку ділення на нуль.
     *Написати програму, яка буде виконувати арифметичні дії зазначені користувачем.
     */

    class Program
    {
        public delegate int Counter(int x, int y);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть перше число:");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введіть дію:");
            string operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                    {
                        Counter Addition = (a, b) => x + y;
                        Console.WriteLine($"Результат обчислення: {Addition(x, y)}");
                        break;
                    }
                case "*":
                    {
                        Counter Multiplication = (a, b) => x * y;
                        Console.WriteLine($"Результат обчислення: {Multiplication(x, y)}");
                        break;
                    }
                case "-":
                    {
                        Counter Substraction = (a, b) => x - y;
                        Console.WriteLine($"Результат обчислення: {Substraction(x, y)}");
                        break;
                    }
                case "/": // як привести до double?
                    {
                        if(y == 0)
                        {
                            Console.WriteLine("Ділення на 0 заборонено");
                        }
                        else
                        {
                            Counter Divission = (a, b) => x / y;
                            Console.WriteLine($"Результат обчислення: {Divission(x, y)}");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введеної дії не існує.");
                        break;
                    }
            }
            Console.ReadKey();
        }   
    }
}
