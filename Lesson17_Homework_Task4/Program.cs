using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_Homework_Task4
{
    /*Створіть анонімний метод, який приймає в якості аргументу масив делегатів і повертає середнє арифметичне значень, 
     * що повертаються після виконання методів на які посилаються делегати в масиві. Методи, на які посилаються делегати з масиву, повертають випадкове значення типу int.
     */
    class Program
    {
        public delegate int MyNumber();
        public delegate int MyDelegate(MyNumber[] array);
        public static int GetRandomNumber()
        {
            Random myRandom = new Random();
            return myRandom.Next(1,100);
        }
            static void Main(string[] args)
        {
            MyNumber[] myNumber = new MyNumber[5];

            for (int i = 0; i < myNumber.Length; i++)
            {
                myNumber[i] = GetRandomNumber;
                Console.WriteLine(myNumber[i]());
            }

            Console.WriteLine();

            MyDelegate myDelegate = delegate (MyNumber[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i]();
                }
                return sum / array.Length;
            };
            Console.WriteLine("Середнє арифметичне дорівнює {0}");

            Console.ReadKey();

        }
    }
}
