using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework23
    {
        static void Main(string[] args)
        {
            int interval = 7;
            int initialNumber = 5;
            
            int maximumNumber;

            Console.WriteLine($"Программа выводит последовательность чисел, с прибавлением к последнему числу: {interval}." +
                $"\nНачальное число последовательности: {initialNumber}. " +
                "\nМаскимальный предел последовательности определяете вы сами.");
            Console.WriteLine("\nВведите максимальное число: ");
            maximumNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Последовательность: ");

            for (initialNumber = 5; initialNumber <= maximumNumber; initialNumber += interval)
            {
                Console.Write(initialNumber + " ");
            }
        }
    }
}
