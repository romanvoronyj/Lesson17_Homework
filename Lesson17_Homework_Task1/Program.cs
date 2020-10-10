using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_Homework_Task1
{
    /*Створіть анонімний метод, який приймає в якості параметрів три цілочисельних аргументу і повертає середнє арифметичне цих аргументів.
     */
    class Program
    {
        public delegate double AverageValue(int x, int y, int z);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            AverageValue myAverageValue = delegate (int x, int y, int z)
            {
                return (x + y + z) / (double)3;
            };

            var result = myAverageValue(1, 9, 13);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
