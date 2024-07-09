using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework23
    {
        static void Main(string[] args)
        {
            int maximumNumber;

            Console.WriteLine("Программа выводит последовательность чисел, с прибавлением к последнему числу: 7." +
                "\nНачальное число последовательности: 5. " +
                "\nМаскимальный предел последовательности определяете вы сами.");
            Console.WriteLine("\nВведите максимальное число: ");
            maximumNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Последовательность: ");

            for (int i = 5; i <= maximumNumber; i += 7)
            {
                Console.Write(i + " ");
            }
        }
    }
}
