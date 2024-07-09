using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework24
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Random random = new Random();

            int number;

            number = random.Next(0, 100);
            Console.WriteLine("Найдём рандомное число не больше 100.");
            Console.WriteLine($"Рандомное число: {number}.");

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"\nСумма положительных чисел меньше {number}(включая число), которые кратны 3 или 5 равна: {sum}");
        }
    }
}
